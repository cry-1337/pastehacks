using pastehack.menu.windows;
using pastehack.menu.windows.main;
using pastehack.menu.windows.main.tabs;
using SDG.Unturned;
using UnityEngine;

namespace pastehack.menu
{
    internal class menu_main : MonoBehaviour
    {
        public static bool global_state = true;
        public static window[] windows = [];

		private void Awake()
        {
			visuals visuals = new(new(0, 0, 200, 300), 3453, false);
			aimbot aimbot = new(new(0, 0, 200, 300), 3455, false);

			main_window main = new(
			[
				visuals,
				aimbot
			]);

			windows =
			[
				main,
				visuals,
				aimbot
			];
		}

		private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                global_state = !global_state;

                if (Player.player)
                    Player.player.look.isIgnoringInput = global_state;
            }
        }

		private void OnGUI()
        {
            if (!global.is_spying && global_state)
            {
				foreach (var window in windows)
				{
					if (window.menu_state)
						window.main();
				}
			} 
        }
    }
}
