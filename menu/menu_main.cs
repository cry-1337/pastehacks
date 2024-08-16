using UnityEngine;

namespace pastehack.menu
{
    [pastehack]
    internal class menu_main : MonoBehaviour
    {
        public Rect menu_rect = new Rect(100, 100, 450, 300);

        void OnGUI()
        {
            menu_rect = GUILayout.Window(-1, menu_rect, window, "pastehacks");
        }

        void window(int id)
        {
            GUILayout.Button("aimbot");
            GUILayout.Button("visuals");
            GUILayout.Button("misc");

            GUI.DragWindow();
        }
    }
}
