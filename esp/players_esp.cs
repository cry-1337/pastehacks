using SDG.Unturned;
using UnityEngine;

namespace pastehack.esp
{
	internal class players_esp : MonoBehaviour
    {
        private readonly GUIContent temp_content = new();

		private bool should_render
		{
			get
			{
				return  MainCamera.instance != null && Player.player != null && !global.is_spying && Provider.clients.Count != 0 && Event.current.type == EventType.Repaint;
			}
		}

		private void OnGUI()
        {
            if (should_render)
            {
				foreach (SteamPlayer sp in Provider.clients)
				{
					Vector2 pos = MainCamera.instance.WorldToScreenPoint(sp.player.transform.position);
					pos.y = Screen.height - pos.y;
					temp_content.text = sp.playerID.playerName;
					Vector2 textSize = GUI.skin.label.CalcSize(temp_content);
					pos.x -= textSize.x * 0.5f;
					GUI.skin.label.Draw(new(pos, textSize), temp_content, -1);
				}
			}
        }
    }
}
