using SDG.Unturned;
using UnityEngine;

namespace pastehack.extensions
{
    internal static class vector2
    {
        public static Vector2 ToScreenPoint(this Vector3 pos)
        {
            Matrix4x4 matrix = MainCamera.instance.projectionMatrix * MainCamera.instance.worldToCameraMatrix;
            Vector3 screenPos = matrix.MultiplyPoint(pos);

            screenPos = new Vector3(screenPos.x + 1f, screenPos.y + 1f, screenPos.z + 1f) / 2f;

            screenPos = new Vector3(screenPos.x * Screen.width, screenPos.y * Screen.height, screenPos.z);
            return new Vector2(screenPos.x, Screen.height - screenPos.y);
        }
        public static Vector2 ToWorldPoint(this Vector3 pos)
        {
            Matrix4x4 matrix = MainCamera.instance.projectionMatrix * MainCamera.instance.worldToCameraMatrix;
            Vector3 screenPos = matrix.MultiplyPoint(pos);

            screenPos = new Vector3(screenPos.x + 1f, screenPos.y + 1f, screenPos.z + 1f) / 2f;

            screenPos = new Vector3(screenPos.x * Screen.width, screenPos.y * Screen.height, screenPos.z);
            return new Vector2(screenPos.x, screenPos.y);
        }
    }
}
