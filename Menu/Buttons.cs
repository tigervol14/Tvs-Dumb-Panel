using MelonLoader;
using TvsDumbPanel.Classes;
using TvsDumbPanel.Mods;
using static TvsDumbPanel.Settings;

namespace TvsDumbPanel.Menu
{
    internal class Buttons
    {
        public static List<List<ButtonInfo>> buttons = new List<List<ButtonInfo>>
        {
            new List<ButtonInfo> // index 0 (main page)
            {
                new ButtonInfo { buttonText = "Settings", method = delegate { SettingsMods.GoTo(1); }, isTogglable = false},
                new ButtonInfo { buttonText = "Movement Mods", method = delegate { SettingsMods.GoTo(2); }, isTogglable = false},
                new ButtonInfo { buttonText = "Fun Mods", method = delegate { SettingsMods.GoTo(3); }, isTogglable = false},
                new ButtonInfo { buttonText = "Horror Mods", method = delegate { SettingsMods.GoTo(5); }, isTogglable = false},
                new ButtonInfo { buttonText = "Cosmetic Mods", method = delegate { SettingsMods.GoTo(6); }, isTogglable = false},
                new ButtonInfo { buttonText = "Visual Mods", method = delegate { SettingsMods.GoTo(7); }, isTogglable = false},
                new ButtonInfo { buttonText = "Credits", method = delegate { SettingsMods.GoTo(8); }, isTogglable = false},
            },
            new List<ButtonInfo> // index 1 (settings)
            {
                new ButtonInfo { buttonText = "Go Back", method = delegate { SettingsMods.GoTo(0); }, isTogglable = false},
                new ButtonInfo { buttonText = "Right Hand Menu", enableMethod = delegate { SettingsMods.RightHandMenu(true); }, disableMethod = delegate { SettingsMods.RightHandMenu(false); }}
            },

            new List<ButtonInfo> // index 2 (movement
            {
                new ButtonInfo { buttonText = "Go Back", method = delegate { SettingsMods.GoTo(0); }, isTogglable = false},
                //new ButtonInfo { buttonText = "Regular Button", method = delegate { Mods.Global.TestButton(); }, isTogglable = false},
                new ButtonInfo { buttonText = "Platforms", method =() => Movement.Platforms(), toolTip = "Whenever you press grip, it spawns a platform under ur hand!"},
                new ButtonInfo { buttonText = "Speedboost", enableMethod = delegate { Mods.Movement.SpeedBoostOn(); }, disableMethod = delegate { Mods.Movement.SpeedBoostOff(); }, toolTip = "Makes you faster!"},
                new ButtonInfo { buttonText = "Zero Gravity", enableMethod = delegate { Mods.Movement.ZeroGravOn(); }, disableMethod = delegate { Mods.Movement.ZeroGravOff(); }, toolTip = "Removes your gravity!"},
                new ButtonInfo { buttonText = "Fly", method =() => Movement.Fly(), toolTip = "Press the X Button to fly!"},
                new ButtonInfo { buttonText = "Noclip", method =() => Movement.Noclip(), toolTip = "Press A to noclip"},
                new ButtonInfo { buttonText = "Upside Down", enableMethod = delegate { Mods.Movement.UpsideDownOn(); }, disableMethod = delegate { Mods.Movement.UpsideDownOff(); }, toolTip = "Makes you upside down, duh."},
            },

            new List<ButtonInfo> // index 3 (fun shiz)
            {
                new ButtonInfo { buttonText = "Go Back", method = delegate { SettingsMods.GoTo(0); }, isTogglable = false},
                new ButtonInfo { buttonText = "Size Mods", method = delegate { SettingsMods.GoTo(4); }, isTogglable = false},
                new ButtonInfo { buttonText = "OG Zero Gravity", enableMethod = delegate { Mods.Fun.OGZeroGOn(); }, disableMethod = delegate { Mods.Fun.OGZeroGOff(); }, toolTip = "its like og zero gravity idk"},
                new ButtonInfo { buttonText = "Tactical Nuke. (local)", method = delegate { Mods.Fun.Nuke(); }, isTogglable = false, toolTip = "Its the like removed nuke thing that mods had"},
                new ButtonInfo { buttonText = "Missle. (local)", method = delegate { Mods.Fun.Missle(); }, isTogglable = false, toolTip = "ITS A FUCKING MISSLE!!!!"},

            },


            new List<ButtonInfo> // index 4 (Size shit) (fun stuff back)
            {

                new ButtonInfo { buttonText = "Go Back", method = delegate { SettingsMods.GoTo(3); }, isTogglable = false},
                new ButtonInfo { buttonText = "Normal Size", method = delegate { Mods.Fun.SizeNormal(); }, isTogglable = false},
                new ButtonInfo { buttonText = "Size 1.5", method = delegate { Mods.Fun.Size1half(); }, isTogglable = false},
                new ButtonInfo { buttonText = "Size 2", method = delegate { Mods.Fun.Size2(); }, isTogglable = false},
                new ButtonInfo { buttonText = "Size 0.75", method = delegate { Mods.Fun.SizeABitSmall(); }, isTogglable = false},
                new ButtonInfo { buttonText = "Smol", method = delegate { Mods.Fun.Smol(); }, isTogglable = false},
                new ButtonInfo { buttonText = "Pixel size", method = delegate { Mods.Fun.pixel(); }, isTogglable = false},

            },

            new List<ButtonInfo> // index 5 (Horror mods)
            {

                new ButtonInfo { buttonText = "Go Back", method = delegate { SettingsMods.GoTo(0); }, isTogglable = false},
                new ButtonInfo { buttonText = "Flashlight", enableMethod = delegate { Mods.Horror.FlashlightOn(); }, disableMethod = delegate { Mods.Horror.FlashlightOff(); }, toolTip = "Lets you use the flashlight anywhere!"},
                new ButtonInfo { buttonText = "Commit Die (level 2)", method = delegate { Mods.Horror.Suicide(); }, isTogglable = false, toolTip = "u fucking die!!"},
                new ButtonInfo { buttonText = "Infinite HP (level 2)", method = delegate { Mods.Horror.InfHP(); }, isTogglable = false, toolTip = "Sets ur hp to 999999"},

            },

            new List<ButtonInfo> // index 6 (Cosmetic mods)
            {

                new ButtonInfo { buttonText = "Go Back", method = delegate { SettingsMods.GoTo(0); }, isTogglable = false},
                new ButtonInfo { buttonText = "Turn into Blue Baboon (local)", enableMethod = delegate { Mods.Cosmetic.bluebaboonOn(); }, disableMethod = delegate { Mods.Cosmetic.bluebaboonOff(); }, toolTip = "Makes you into blue baboon from level 2 (this is deadass in the game)"},

            },

            new List<ButtonInfo> // index 7 (Visual Mods)
            {

                new ButtonInfo { buttonText = "Go Back", method = delegate { SettingsMods.GoTo(0); }, isTogglable = false},
                new ButtonInfo { buttonText = "No fog", method = delegate { Mods.Visual.NoFog(); }, isTogglable = false},

            },

            new List<ButtonInfo> // index 8 (Credits)
            {

                new ButtonInfo { buttonText = "Go Back", method = delegate { SettingsMods.GoTo(0); }, isTogglable = false},
                new ButtonInfo { buttonText = "TV14", method = delegate { Global.TestButton(); }, isTogglable = false, toolTip = "TV14 is the creator of the menu and is the lead developer."},
                new ButtonInfo { buttonText = "SomeGuyLol", method = delegate { Global.TestButton(); }, isTogglable = false, toolTip = "SomeGuyLol Helped me create this menu and also made the port of II's Stupid template to capuchin."},

            },
        };
    }
}
