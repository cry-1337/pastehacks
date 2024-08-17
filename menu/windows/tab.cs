namespace pastehack.menu.windows
{
    public abstract class tab
    {
        public abstract string name { get; }
        
        public abstract void draw(int tab_id);
    }
}
