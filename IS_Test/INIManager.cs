using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace IS_Test
{
    enum INI_ID
    {
        SERVER_IDENTIFIER,
        SERVER,
        PORT,
        IMAGENOW_IDENTIFIER,
        USER,
        PASSWORD,
        SESSIONHASH,
        RETURNTYPE,
        GENERAL_IDENTIFIER,
        LOG_LEVEL,
        UPLOAD_DIR,
        DOWNLOAD_DIR,
        COUNT
    }

    class INI_Pair
    {
        public INI_ID ID;
        public string Description;
        public string Value;

        public INI_Pair()
        {
            Description = string.Empty;
            Value = string.Empty;
        }

        public INI_Pair(INI_ID id, string desc, string value)
        {
            ID = id;
            Description = desc;
            Value = value;
        }

    }

    static class INIManager
    {
        private static string directory = "etc";
        private static string file = "settings.ini";
        private static readonly string separator = "=";
        private static string iniLocation = string.Empty;

        private static INI_Pair[] Pairs = {
                                       new INI_Pair(INI_ID.SERVER_IDENTIFIER,   "[Server Settings]",    string.Empty),
                                       new INI_Pair(INI_ID.SERVER,              "Server",               "localhost"),
                                       new INI_Pair(INI_ID.PORT,                "Port",                 "8080"),
                                       new INI_Pair(INI_ID.IMAGENOW_IDENTIFIER, "[ImageNow Settings]",  string.Empty),
                                       new INI_Pair(INI_ID.USER,                "Username",             "test1"),
                                       new INI_Pair(INI_ID.PASSWORD,            "Password",             "ImageNow!"),
                                       new INI_Pair(INI_ID.SESSIONHASH,         "SessionHash",          string.Empty),
                                       new INI_Pair(INI_ID.RETURNTYPE,          "Return.Type",          "application/xml"),
                                       new INI_Pair(INI_ID.GENERAL_IDENTIFIER,  "[General Settings]",   string.Empty),
                                       new INI_Pair(INI_ID.UPLOAD_DIR,          "default.upload.directory",      string.Empty),
                                       new INI_Pair(INI_ID.DOWNLOAD_DIR,        "default.download.directory",    string.Empty),
                                       new INI_Pair(INI_ID.LOG_LEVEL,           "debug.level.file",    "0"),
                                   };

        public static void LoadSettings()
        {
            iniLocation = string.Format("{0}/{1}", directory, file);

            try
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                if (!File.Exists(iniLocation))
                {
                    Save();
                }
                else
                {
                    Load();
                }
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Could not access directory ({0}): {1}", directory, e.Message));
            }
        }

        public static void UpdateValue(INI_ID id, string value)
        {
            foreach (INI_Pair pair in Pairs)
            {
                if (pair.ID == id)
                {
                    pair.Value = value;
                    break;
                }
            }
            Save();
        }

        public static void UpdateValue(string desc, string value)
        {
            foreach (INI_Pair pair in Pairs)
            {
                if (pair.Description == desc)
                {
                    pair.Value = value;
                    break;
                }
            }
            Save();
        }

        public static string GetValue(INI_ID id)
        {
            foreach (INI_Pair pair in Pairs)
            {
                if (pair.ID == id)
                {
                    return pair.Value;
                }
            }

            return string.Empty;
        }

        public static void Save()
        {
            string[] pairs = new string[(int)INI_ID.COUNT];

            try
            {
                for (int i = 0; i < Pairs.Length; i++)
                {
                    string pair = string.Empty;
                    if (Pairs[i].Description.IndexOf("[") != -1)
                    {
                        pair = Pairs[i].Description;
                        if (i > 0)
                            pairs[i - 1] += Environment.NewLine;
                    }
                    else
                        pair = string.Format("{0}{1} {2}", Pairs[i].Description, separator, Pairs[i].Value);

                    pairs[i] = pair;
                }

                File.WriteAllLines(iniLocation, pairs);
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Could not save ini settings: {0}", e.Message));
            }
        }

        public static void Load()
        {
            try
            {
                string[] lines = File.ReadAllLines(iniLocation);

                for (int i = 0; i < lines.Length; i++)
                {
                    int tempIndex = lines[i].IndexOf(separator);
                    if (tempIndex < 0)
                        continue;

                    string identifier = lines[i].Substring(0, tempIndex).Trim();
                    string value = lines[i].Substring(tempIndex + 1).Trim();

                    UpdateValue(identifier, value);
                }
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Could not load ini settings: {0}", e.Message));
            }

            int.TryParse(GetValue(INI_ID.LOG_LEVEL), out Logger.LOG_LEVEL);
        }
    }
}
