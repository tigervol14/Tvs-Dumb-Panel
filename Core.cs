using Il2Cpp;
using Il2CppInterop.Runtime.Injection;
using MelonLoader;
using System.Linq;

[assembly: MelonInfo(typeof(TvsDumbPanel.Core), TvsDumbPanel.PluginInfo.Name, TvsDumbPanel.PluginInfo.Version, TvsDumbPanel.PluginInfo.Credits, null)]
[assembly: MelonGame("Duttbust", "Capuchin")]

namespace TvsDumbPanel
{
    public class Core : MelonMod
    {
        public static Il2Cpp.FusionPlayer[] players = [];
        public static FusionPlayer localPlayer;
        private readonly HarmonyLib.Harmony harmony = new(PluginInfo.HarmonyName);

        public override void OnInitializeMelon()
        {
            ClassInjector.RegisterTypeInIl2Cpp<TvsDumbPanel.Classes.ColorChanger>();
            ClassInjector.RegisterTypeInIl2Cpp<TvsDumbPanel.Classes.TimedBehaviour>();
            ClassInjector.RegisterTypeInIl2Cpp<TvsDumbPanel.Classes.Button>();
            ClassInjector.RegisterTypeInIl2Cpp<TvsDumbPanel.Classes.ClampColor>();
            ClassInjector.RegisterTypeInIl2Cpp<TvsDumbPanel.Classes.EspObject>();
            LoggerInstance.Msg("Initialized.");
            harmony.PatchAll();
        }
    }
}