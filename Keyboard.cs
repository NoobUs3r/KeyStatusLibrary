// Key code documentation:
// http://msdn.microsoft.com/en-us/library/dd375731%28v=VS.85%29.aspx
using System.Collections.Generic;

namespace NoobUser.KeyStatus
{
    public enum Key : int
    {
        Backspace = 0x08,
        Tab = 0x09,
        Clear = 0x0C,
        Enter = 0x0D,
        Shift = 0x10,
        Ctrl = 0x11,
        Alt = 0x12,
        Pause = 0x13,
        CapsLock = 0x14,
        Esc = 0x1B,
        Space = 0x20,
        PageUp = 0x21,
        PageDown = 0x22,
        End = 0x23,
        Home = 0x24,
        Left = 0x25,
        Up = 0x26,
        Right = 0x27,
        Down = 0x28,
        Select = 0x29,
        Print = 0x2A,
        Execute = 0x2B,
        PrintScreen = 0x2C,
        Insert = 0x2D,
        Del = 0x2E,
        Help = 0x2F,
        D0 = 0x30,
        D1 = 0x31,
        D2 = 0x32,
        D3 = 0x33,
        D4 = 0x34,
        D5 = 0x35,
        D6 = 0x36,
        D7 = 0x37,
        D8 = 0x38,
        D9 = 0x39,
        A = 0x41,
        B = 0x42,
        C = 0x43,
        D = 0x44,
        E = 0x45,
        F = 0x46,
        G = 0x47,
        H = 0x48,
        I = 0x49,
        J = 0x4A,
        K = 0x4B,
        L = 0x4C,
        M = 0x4D,
        N = 0x4E,
        O = 0x4F,
        P = 0x50,
        Q = 0x51,
        R = 0x52,
        S = 0x53,
        T = 0x54,
        U = 0x55,
        V = 0x56,
        W = 0x57,
        X = 0x58,
        Y = 0x59,
        Z = 0x5A,
        LeftWin = 0x5B,
        RightWin = 0x5C,
        Application = 0x5D,
        Sleep = 0x5F,
        Num0 = 0x60,
        Num1 = 0x61,
        Num2 = 0x62,
        Num3 = 0x63,
        Num4 = 0x64,
        Num5 = 0x65,
        Num6 = 0x66,
        Num7 = 0x67,
        Num8 = 0x68,
        Num9 = 0x69,
        Multiply = 0x6A,
        Add = 0x6B,
        Separator = 0x6C,
        Subtract = 0x6D,
        Decimal = 0x6E,
        Divide = 0x6F,
        F1 = 0x70,
        F2 = 0x71,
        F3 = 0x72,
        F4 = 0x73,
        F5 = 0x74,
        F6 = 0x75,
        F7 = 0x76,
        F8 = 0x77,
        F9 = 0x78,
        F10 = 0x79,
        F11 = 0x7A,
        F12 = 0x7B,
        F13 = 0x7C,
        F14 = 0x7D,
        F15 = 0x7E,
        F16 = 0x7F,
        F17 = 0x80,
        F18 = 0x81,
        F19 = 0x82,
        F20 = 0x83,
        F21 = 0x84,
        F22 = 0x85,
        F23 = 0x86,
        F24 = 0x87,
        NumLock = 0x90,
        Scroll = 0x91,
        LeftShift = 0xA0,
        RightShift = 0xA1,
        LeftCtrl = 0xA2,
        RightCtrl = 0xA3,
        LeftMenu = 0xA4,
        RightMenu = 0xA5,
        BrowserBack = 0xA6,
        BrowserForward = 0xA7,
        BrowserRefresh = 0xA8,
        BrowserStop = 0xA9,
        BrowserSearch = 0xAA,
        BrowserFavorites = 0xAB,
        BrowserHome = 0xAC,
        VolMute = 0xAD,
        VolDown = 0xAE,
        VolUp = 0xAF,
        NextTrack = 0xB0,
        PreviousTrack = 0xB1,
        StopMedia = 0xB2,
        PausePlay = 0xB3,
        StartMail = 0xB4,
        SelectMedia = 0xB5,
        StartApplication1 = 0xB6,
        StartApplication2 = 0xB7,
        OEM1 = 0xBA,
        OEM_Plus = 0xBB,
        OEM_Comma = 0xBC,
        OEM_Minus = 0xBD,
        OEM_Period = 0xBE,
        OEM2 = 0xBF,
        OEM3 = 0xC0,
        OEM4 = 0xDB,
        OEM5 = 0xDC,
        OEM6 = 0xDD,
        OEM7 = 0xDE,
        OEM8 = 0xDF,
        OEM102 = 0xE2,
        Attn = 0xF6,
        Crsel = 0xF7,
        Exsel = 0xF8,
        Ereof = 0xF9,
        Play = 0xFA,
        Zoom = 0xFB,
        PA1 = 0xFD,
        OEM_Clear = 0xFE
    }

    public static class Keyboard
    {
        // A positional bit flag indicating the part of a key state denoting key pressed.
        private const int KeyPressed = 0x8000;

        // Storing 1 if a key is toggled
        private static Dictionary<string, int> toggledKeys = new Dictionary<string, int>()
        {
            {"Backspace", 0},
            {"Tab", 0},
            {"Clear", 0},
            {"Enter", 0},
            {"Shift", 0},
            {"Ctrl", 0},
            {"Alt", 0},
            {"Pause", 0},
            {"CapsLock", 0},
            {"Esc", 0},
            {"Space", 0},
            {"PageUp", 0},
            {"PageDown", 0},
            {"End", 0},
            {"Home", 0},
            {"Left", 0},
            {"Up", 0},
            {"Right", 0},
            {"Down", 0},
            {"Select", 0},
            {"Print", 0},
            {"Execute", 0},
            {"PrintScreen", 0},
            {"Insert", 0},
            {"Del", 0},
            {"Help", 0},
            {"D0", 0},
            {"D1", 0},
            {"D2", 0},
            {"D3", 0},
            {"D4", 0},
            {"D5", 0},
            {"D6", 0},
            {"D7", 0},
            {"D8", 0},
            {"D9", 0},
            {"A", 0},
            {"B", 0},
            {"C", 0},
            {"D", 0},
            {"E", 0},
            {"F", 0},
            {"G", 0},
            {"H", 0},
            {"I", 0},
            {"J", 0},
            {"K", 0},
            {"L", 0},
            {"M", 0},
            {"N", 0},
            {"O", 0},
            {"P", 0},
            {"Q", 0},
            {"R", 0},
            {"S", 0},
            {"T", 0},
            {"U", 0},
            {"V", 0},
            {"W", 0},
            {"X", 0},
            {"Y", 0},
            {"Z", 0},
            {"LeftWin", 0},
            {"RightWin", 0},
            {"Application", 0},
            {"Sleep", 0},
            {"Num0", 0},
            {"Num1", 0},
            {"Num2", 0},
            {"Num3", 0},
            {"Num4", 0},
            {"Num5", 0},
            {"Num6", 0},
            {"Num7", 0},
            {"Num8", 0},
            {"Num9", 0},
            {"Multiply", 0},
            {"Add", 0},
            {"Separator", 0},
            {"Subtract", 0},
            {"Decimal", 0},
            {"Divide", 0},
            {"F1", 0},
            {"F2", 0},
            {"F3", 0},
            {"F4", 0},
            {"F5", 0},
            {"F6", 0},
            {"F7", 0},
            {"F8", 0},
            {"F9", 0},
            {"F10", 0},
            {"F11", 0},
            {"F12", 0},
            {"F13", 0},
            {"F14", 0},
            {"F15", 0},
            {"F16", 0},
            {"F17", 0},
            {"F18", 0},
            {"F19", 0},
            {"F20", 0},
            {"F21", 0},
            {"F22", 0},
            {"F23", 0},
            {"F24", 0},
            {"NumLock", 0},
            {"Scroll", 0},
            {"LeftShift", 0},
            {"RightShift", 0},
            {"LeftCtrl", 0},
            {"RightCtrl", 0},
            {"LeftMenu", 0},
            {"RightMenu", 0},
            {"BrowserBack", 0},
            {"BrowserForward", 0},
            {"BrowserRefresh", 0},
            {"BrowserStop", 0},
            {"BrowserSearch", 0},
            {"BrowserFavorites", 0},
            {"BrowserHome", 0},
            {"VolMute", 0},
            {"VolDown", 0},
            {"VolUp", 0},
            {"NextTrack", 0},
            {"PreviousTrack", 0},
            {"StopMedia", 0},
            {"PausePlay", 0},
            {"StartMail", 0},
            {"SelectMedia", 0},
            {"StartApplication1", 0},
            {"StartApplication2", 0},
            {"OEM1", 0},
            {"OEM_Plus", 0},
            {"OEM_Comma", 0},
            {"OEM_Minus", 0},
            {"OEM_Period", 0},
            {"OEM2", 0},
            {"OEM3", 0},
            {"OEM4", 0},
            {"OEM5", 0},
            {"OEM6", 0},
            {"OEM7", 0},
            {"OEM8", 0},
            {"OEM102", 0},
            {"Attn", 0},
            {"Crsel", 0},
            {"Exsel", 0},
            {"Ereof", 0},
            {"Play", 0},
            {"Zoom", 0},
            {"PA1", 0},
            {"OEM_Clear", 0}
        };

        // Storing 1 if a key was up
        private static Dictionary<string, int> previouslyUpKeys = new Dictionary<string, int>()
        {
            {"Backspace", 0},
            {"Tab", 0},
            {"Clear", 0},
            {"Enter", 0},
            {"Shift", 0},
            {"Ctrl", 0},
            {"Alt", 0},
            {"Pause", 0},
            {"CapsLock", 0},
            {"Esc", 0},
            {"Space", 0},
            {"PageUp", 0},
            {"PageDown", 0},
            {"End", 0},
            {"Home", 0},
            {"Left", 0},
            {"Up", 0},
            {"Right", 0},
            {"Down", 0},
            {"Select", 0},
            {"Print", 0},
            {"Execute", 0},
            {"PrintScreen", 0},
            {"Insert", 0},
            {"Del", 0},
            {"Help", 0},
            {"Zero", 0},
            {"One", 0},
            {"Two", 0},
            {"Three", 0},
            {"Four", 0},
            {"Five", 0},
            {"Six", 0},
            {"Seven", 0},
            {"Eight", 0},
            {"Nine", 0},
            {"A", 0},
            {"B", 0},
            {"C", 0},
            {"D", 0},
            {"E", 0},
            {"F", 0},
            {"G", 0},
            {"H", 0},
            {"I", 0},
            {"J", 0},
            {"K", 0},
            {"L", 0},
            {"M", 0},
            {"N", 0},
            {"O", 0},
            {"P", 0},
            {"Q", 0},
            {"R", 0},
            {"S", 0},
            {"T", 0},
            {"U", 0},
            {"V", 0},
            {"W", 0},
            {"X", 0},
            {"Y", 0},
            {"Z", 0},
            {"LeftWin", 0},
            {"RightWin", 0},
            {"Application", 0},
            {"Sleep", 0},
            {"Num0", 0},
            {"Num1", 0},
            {"Num2", 0},
            {"Num3", 0},
            {"Num4", 0},
            {"Num5", 0},
            {"Num6", 0},
            {"Num7", 0},
            {"Num8", 0},
            {"Num9", 0},
            {"Multiply", 0},
            {"Add", 0},
            {"Separator", 0},
            {"Subtract", 0},
            {"Decimal", 0},
            {"Divide", 0},
            {"F1", 0},
            {"F2", 0},
            {"F3", 0},
            {"F4", 0},
            {"F5", 0},
            {"F6", 0},
            {"F7", 0},
            {"F8", 0},
            {"F9", 0},
            {"F10", 0},
            {"F11", 0},
            {"F12", 0},
            {"F13", 0},
            {"F14", 0},
            {"F15", 0},
            {"F16", 0},
            {"F17", 0},
            {"F18", 0},
            {"F19", 0},
            {"F20", 0},
            {"F21", 0},
            {"F22", 0},
            {"F23", 0},
            {"F24", 0},
            {"NumLock", 0},
            {"Scroll", 0},
            {"LeftShift", 0},
            {"RightShift", 0},
            {"LeftCtrl", 0},
            {"RightCtrl", 0},
            {"LeftMenu", 0},
            {"RightMenu", 0},
            {"BrowserBack", 0},
            {"BrowserForward", 0},
            {"BrowserRefresh", 0},
            {"BrowserStop", 0},
            {"BrowserSearch", 0},
            {"BrowserFavorites", 0},
            {"BrowserHome", 0},
            {"VolMute", 0},
            {"VolDown", 0},
            {"VolUp", 0},
            {"NextTrack", 0},
            {"PreviousTrack", 0},
            {"StopMedia", 0},
            {"PausePlay", 0},
            {"StartMail", 0},
            {"SelectMedia", 0},
            {"StartApplication1", 0},
            {"StartApplication2", 0},
            {"OEM1", 0},
            {"OEM_Plus", 0},
            {"OEM_Comma", 0},
            {"OEM_Minus", 0},
            {"OEM_Period", 0},
            {"OEM2", 0},
            {"OEM3", 0},
            {"OEM4", 0},
            {"OEM5", 0},
            {"OEM6", 0},
            {"OEM7", 0},
            {"OEM8", 0},
            {"OEM102", 0},
            {"Attn", 0},
            {"Crsel", 0},
            {"Exsel", 0},
            {"Ereof", 0},
            {"Play", 0},
            {"Zoom", 0},
            {"PA1", 0},
            {"OEM_Clear", 0}
        };

        // Returns a value indicating if a given key is pressed.
        public static bool IsKeyDown(Key key)
        {
            return (GetKeyState((int)key) & KeyPressed) != 0;
        }

        public static bool IsKeyUp(Key key)
        {
            return (GetKeyState((int)key) & KeyPressed) == 0;
        }

        public static bool IsKeyToggled(Key key)
        {
            string keyString = key.ToString();

            // If a key is down but previously was up- change toggle status
            if (IsKeyDown(key))
            {
                if (previouslyUpKeys[keyString] == 1)
                {
                    if (toggledKeys[keyString] == 1)
                        toggledKeys[keyString] = 0;
                    else
                        toggledKeys[keyString] = 1;

                    previouslyUpKeys[keyString] = 0;
                }
            }
            else
            {
                previouslyUpKeys[keyString] = 1;
            }

            return toggledKeys[keyString] == 1;
        }

        // Gets the key state of a key
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetKeyState(int key);
    }
}