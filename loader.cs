using pastehack.esp;
using pastehack.menu;
using SDG.Unturned;
using UnityEngine;

namespace pastehack
{
	public static class loader
    {
        private static GameObject? game_object;

        public static void load()
        {
            game_object = new GameObject("aboba");
            Object.DontDestroyOnLoad(game_object);

			game_object.AddComponent<menu_main>();
            game_object.AddComponent<players_esp>();

			UnturnedLog.info("[+] paste injected");
        }
    }
}
