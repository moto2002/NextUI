﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NextUI
{
    // The possition type of UI element
    public enum UIFormType
    {
        // Normal window: 
        // Individual window which will not influence other UI elements
        Normal,
        // Fixed window:
        // Container window which will be the parent window of some other UI elements.
        // Usually as a root window.
        Fixed,
        // Pop window:
        // Used to display information
        PopUp
    }

    // The display mode od UI element
    public enum UIShowMode
    {
        // Normal display
        General,
        // Reserve change
        ReserveChange,
        // Hiden all
        // when in this mode, UI manager will hide all oter UI elements
        HideOther
    }

    // Transparency of the UI element
    public enum UILuencyType
    {
        Lucency,
        Translucence,
        ImPenetrable,
        Pentrate
    }

    public class GlobalConfig
    {
        // Main canvas object
        public const string CONFIG_CANVAS = "NextUI";

        // Root management nodes objects
        public const string CONFIG_NORMAL = "Normal";
        public const string CONFIG_FIXED = "Fixed";
        public const string CONFIG_POPUP = "PopUp";
        public const string CONFIG_SCRIPT = "UIScripts";
    }
}
