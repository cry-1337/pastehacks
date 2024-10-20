using UnityEngine;

namespace pastehack.menu.windows.main
{
	public class main_window(window[] tabs) : window(new(100, 100, 200, 400), -1, "pastehack", true)
    {
		private readonly window[] tabs = tabs;

		protected override void content()
		{
            foreach (var tab in tabs)
            {
                if (GUILayout.Button(tab.title))
                {
					tab.menu_state = !tab.menu_state;
				}
            }
        }
	}
}
