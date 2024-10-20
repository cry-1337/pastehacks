using UnityEngine;

namespace pastehack.menu
{
    public static class menu_helper
    {
        public static void toggle(string name, ref bool val) => val = GUILayout.Toggle(val, name);
    }
}
