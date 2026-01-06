using TvsDumbPanel.Classes;
using UnityEngine;
using static TvsDumbPanel.Menu.Main;

namespace TvsDumbPanel
{
    internal class Settings
    {
        public static float colMult = 1f;
        public static ExtGradient backgroundColorStatic = GetSolidExtGradient(new Color32(255, 234, 0, 255));

        public static ExtGradient background = new ExtGradient
        {
            colors = new GradientColorKey[]
            {
                new GradientColorKey(new Color32(255, 234, 0, 255), 0f),
                new GradientColorKey(new Color32(255, 234, 0, 255), 0.5f),
                new GradientColorKey(new Color32(255, 234, 0, 255), 1f)
            }
        };

        public static ExtGradient backgroundColor = background;
        public static ExtGradient[] buttonColors = new[]
        {
            GetSolidExtGradient(new Color32(255, 207, 0, 255)), // Disabled
            GetSolidExtGradient(new Color32(255, 187, 0, 255)) // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.white // Enabled
        };

        public static Font currentFont = Resources.GetBuiltinResource<Font>("Arial.ttf");

        public static bool fpsCounter = true;
        public static bool disconnectButton = true;
        public static bool rightHanded = false;
        public static KeyCode keyboardButton = KeyCode.Z;
        public static Vector3 menuSize = new Vector3(0.1f, 1f, 1f); // Depth, Width, Height
        public static int buttonsPerPage = 8;
    }
}
