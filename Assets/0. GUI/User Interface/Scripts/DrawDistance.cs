using UnityEngine;

namespace GUI_VR
{
    public class DrawDistance : MonoBehaviour
    {
        [Header("Settings")]
        [Range(0f, 10f)] public float distance;
        public Color color;
        [Space]
        [TextArea] public string note;

        private void OnDrawGizmos()
        {
            Gizmos.color = color;
            Gizmos.DrawWireSphere(transform.position, distance);
        }
    }
}