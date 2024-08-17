using SDG.Unturned;
using System;
using System.Reflection;
using UnityEngine;

public static class global
{
    public static bool spy;
    public static bool toggle_test1;
}

namespace pastehack
{
    [AttributeUsage(AttributeTargets.Class)]
    public class pastehack : Attribute { }

    public static class loader
    {
        static GameObject obj;

        static void add_components()
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
                if (type.IsDefined(typeof(pastehack)))
                    obj.AddComponent(type);
        }

        public static void load()
        {
            obj = new GameObject("aboba");
            GameObject.DontDestroyOnLoad(obj);

            add_components();

            UnturnedLog.info("[+] paste injected");
        }
    }
}
