using UnityEngine;

namespace pastehack.menu.windows
{
    public abstract class window(Rect rect, int id, string title, bool menu_state = true)
	{
		public Rect rect { get; set; } = rect;

		public int id { get; set; } = id;

		public string title { get; set; } = title;

		public bool menu_state { get; set; } = menu_state;

		public void main()
		{
			rect = GUI.Window(id, rect, window_function, title);
		}

		protected abstract void content();

		private void window_function(int id)
		{
			content();
		}
    }
}
