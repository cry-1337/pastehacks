using UnityEngine;

namespace pastehack.esp
{
    [pastehack]
    internal class esp_main : MonoBehaviour
    {
        public static Material material;

        void Awake()
        {
            material = new Material(Shader.Find("Hidden/Internal-Colored")); material.hideFlags = HideFlags.HideAndDontSave; material.SetInt("_SrcBlend", 5); material.SetInt("_DstBlend", 10); material.SetInt("_Cull", 0); material.SetInt("_ZWrite", 0);
        }

        void OnGUI()
        {
        }
    }
}
