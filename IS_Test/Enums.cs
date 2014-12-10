using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IS_Test
{
    public enum captureSourceType
    {
        FAX_AGENT,
        IMPORT_AGENT,
        CONNECTOR_SAP,
        INTERACT_OUTLOOK,
        EXTERNAL
    }

    public enum contextMapItemSourceType
    {
        PREDEFINED_LIST,
        USER_NAME_SELECT,
        DOC_TYPE_LIST
    }

    public enum actionType
    {
        RETURN_CONFLICTS,
        APPEND,
        REPLACE
    }

    public enum instanceType
    {
        DOCUMENT,
        FOLDER,
        DOCUMENT_SHORTCUT,
        FOLDER_SHORTCUT
    }

    public enum folderSearchMode
    {
        CREATE,
        MOVE,
        SHORTCUT
    }

    public enum learnModeType
    {
        DOS,
        EXTERNAL,
        MANUAL_ENTRY,
        WINDOW_WALKER,
        HYPERLEARN,
        VIEWPOINT,
        INTERNET_EXPLORER,
        TERMINAL,
        FAX_AGENT,
        MAIL_AGENT,
        IMPORT_AGENT,
        CONNECTOR_SAP,
        INTERACT_OUTLOOK
    }

    public enum rotation
    {
        DEGREES_90,
        DEGREES_180,
        DEGREES_270
    }

    public enum mode
    {
        FIRST,
        LAST,
        BEFORE,
        AFTER
    }

    public enum moveMode
    {
        MOVE,
        COPY
    }

    public enum serverActionModes
    {
        SCRIPT
    }

    public enum viewCategory
    {
        DOCUMENT,
        FOLDER,
        TASK,
        WORKFLOW
    }

    public enum refreshResultCategory
    {
        DOCUMENT,
        FOLDER,
        WORKFLOW
    }

    public enum resultCategory
    {
        DOCUMENT,
        FOLDER,
        FOLDER_CONTENT,
        TASK,
        WORKFLOW
    }

    public enum workflowItemType
    {
        DOCUMENT,
        FOLDER
    }

    public enum workflowItemPriority
    {
        LOW,
        MEDIUM,
        HIGH
    }

    public enum routeType
    {
        AUTO,
        BALANCED,
        CONDITIONAL,
        CONDITIONAL_PARALLEL,
        MANUAL,
        PARALLEL,
        PEER
    }

    public enum workflowState
    {
        IDLE,
        PENDING,
        WORKING
    }

    public enum privilegeValue
    {
        GRANTED,
        UNSET,
        DENIED
    }

    class Enums
    {
    }
}
