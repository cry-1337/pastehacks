using UnityEngine;

namespace pastehack.menu.windows
{
    public abstract class window
    {
        public abstract Rect rect { get; set; }
        public abstract int id { get; set; }
        public abstract string title { get; set; }
        public abstract bool menu_state { get; set; }

        public abstract void main();
    }
}
