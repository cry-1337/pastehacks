using SDG.Unturned;
using System;
using System.Reflection;
using UnityEngine;

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

            add_components();

            UnturnedLog.info("[+] paste injected");
        }
    }
}
