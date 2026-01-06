using System;
using UnityEngine;
using static TvsDumbPanel.Menu.Main;

namespace TvsDumbPanel.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = GetSolidGradientKey(new Color32(0, 0, 0, 255));

        public bool isRainbow = false;
    }
}
