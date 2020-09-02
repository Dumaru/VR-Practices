using UnityEngine;

namespace Locomotion
{
    /// <summary>
    /// Calls the teleport manager to teleport the user to this position
    /// </summary>
    public class TeleportPoint : MonoBehaviour
    {
        public void Teleport()
        {
            TeleportManager.Instance.Teleport(transform.position);
        }
    }

}
