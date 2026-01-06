using static TvsDumbPanel.Menu.Main;
using static TvsDumbPanel.Settings;

namespace TvsDumbPanel.Mods
{
    internal class SettingsMods
    {
        public static void GoTo(int page)
        {
            currentButtonCategory = page;
        }
        
        public static void RightHandMenu(bool b)
        {
            rightHanded = b;
        }
    }
}
