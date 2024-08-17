using pastehack.menu.windows;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using UnityEngine;
using System;
using SDG.Unturned;

namespace pastehack.menu
{
    [pastehack]
    internal class menu_main : MonoBehaviour
    {
        public static bool global_state = true;
        public static List<window> windows = new List<window>();

        void Awake()
        {
            var assembly_windows = from t in Assembly.GetExecutingAssembly().GetTypes()
                                   where t.BaseType == typeof(window)
                                   && t.GetConstructor(Type.EmptyTypes) != null
                                   select Activator.CreateInstance(t) as window;

            foreach (var item in assembly_windows)
                windows.Add(item);
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                global_state = !global_state;

                if (Player.player)
                    Player.player.look.isIgnoringInput = global_state;
            }
        }

        void OnGUI()
        {
            if (global.spy)
                return;

            foreach (var window in windows)
            {
                if (window.menu_state & global_state)
                    window.main();
                else if (!window.menu_state)
                    window.main();
            }
        }
    }
}
