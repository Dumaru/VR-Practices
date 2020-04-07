using UnityEngine;

public class TeleportPoint : MonoBehaviour
{
	
	public void Teleport ()
	{
		TeleportManager.Instance.Teleport(transform.position);
	}
	
    
}
