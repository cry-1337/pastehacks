using UnityEngine;

namespace pastehack.menu.windows.main.tabs
{
    public class visuals : tab
    {
        public override string name { get; } = "visuals";
        public Rect rect = new Rect(520, 100, 200, 400);

        public override void draw(int tab_id)
        {
            rect = GUI.Window(tab_id, rect, (int id) => {
                menu_helper.toggle("esp", ref global.c.esp);

                GUI.DragWindow();
            }, name);
        }
    }
}
