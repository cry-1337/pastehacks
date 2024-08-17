using UnityEngine;

namespace pastehack.menu.windows.main.tabs
{
    public class aimbot : tab
    {
        public override string name { get; } = "aimbot";
        public Rect rect = new Rect(310, 100, 200, 400);

        public override void draw(int tab_id)
        {
            rect = GUI.Window(tab_id, rect, (int id) => {
                global.toggle_test1 = GUILayout.Toggle(global.toggle_test1, "test toggle");

                GUI.DragWindow();
            }, name);
        }
    }
}
