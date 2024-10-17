using pastehack.menu.windows.main.tabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace pastehack.menu.windows.main
{
    public class main_window : window
    {
        public main_window()
        {
            var assembly_tabs = from t in Assembly.GetExecutingAssembly().GetTypes()
                                   where t.BaseType == typeof(tab)
                                   && t.GetConstructor(Type.EmptyTypes) != null
                                   select Activator.CreateInstance(t) as tab;
            
            foreach (var item in assembly_tabs)
                tabs.Add(item);
        }

        List<tab> tabs = new List<tab>();
        List<tab> opened_tabs = new List<tab>();

        public override Rect rect { get; set; } = new Rect(100, 100, 200, 400);
        public override int id { get; set; } = -1;
        public override string title { get; set; } = "pastehack";
        public override bool menu_state { get; set; } = true;

        public override void main()
        {
            rect = GUILayout.Window(id, rect, (int id) => {
                foreach (var tab in tabs)
                    if (GUILayout.Button(tab.name))
                        if (!opened_tabs.Contains(tab))
                            opened_tabs.Add(tab);
                        else
                            opened_tabs.Remove(tab);

                GUI.DragWindow();
            }, title);

            int tab_id = -2;

            foreach (tab tab in opened_tabs)
            {
                tab.draw(tab_id);
                tab_id--;
            }
        }
    }
}
