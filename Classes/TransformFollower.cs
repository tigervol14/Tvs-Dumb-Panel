using TvsDumbPanel.Mods;
using UnityEngine;
using TvsDumbPanel.Menu;
using static TvsDumbPanel.Menu.Main;
using static TvsDumbPanel.Settings;
using Il2Cpp;

namespace TvsDumbPanel.Classes
{
    public class EspObject : MonoBehaviour
    {
        public FusionPlayer attachedPlayer;

        void Update()
        {
            if (attachedPlayer != null)
            {
                gameObject.transform.position = attachedPlayer.HeadTarget.transform.position + attachedPlayer.HeadTarget.transform.forward * -0.075f + attachedPlayer.HeadTarget.transform.up * -0.3f;
            }
        }
	}
}
