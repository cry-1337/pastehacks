using pastehack.extensions;
using SDG.Unturned;
using System.Collections.Generic;
using UnityEngine;

namespace pastehack.esp
{
    [pastehack]
    internal class esp_main : MonoBehaviour
    {
        public static Material material;
        static List<GameObject> esp_objects = new List<GameObject>();

        void Awake()
        {
            material = new Material(Shader.Find("Hidden/Internal-Colored")); material.hideFlags = HideFlags.HideAndDontSave; material.SetInt("_SrcBlend", 5); material.SetInt("_DstBlend", 10); material.SetInt("_Cull", 0); material.SetInt("_ZWrite", 0);
        }

        void Update()
        {
            foreach (SteamPlayer sp in Provider.clients)
                esp_objects.Add(sp.player.gameObject);
        }

        void OnGUI()
        {
            foreach (GameObject obj in esp_objects)
            {
                if (obj == null | global.spy)
                    continue;

                Vector2 pos = new Vector3(obj.transform.position.x, obj.transform.position.y, obj.transform.position.z).ToScreenPoint();
                GUI.Label(new Rect(pos.x, pos.y, 500, 500), obj.name);
            }
        }
    }
}
