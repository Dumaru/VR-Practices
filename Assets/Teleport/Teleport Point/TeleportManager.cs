using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportManager : MonoBehaviour
{
	#region Singleton

	private static TeleportManager instance;
	public static TeleportManager Instance
	{
		get
		{
			if (instance == null)
			{
				instance = new TeleportManager ();
			}
			return instance;
		}
	}

	#endregion

	[Header ("Teleport")]
	public Image imgFade;
	[Range (0f, 1f)] public float timeTeleport = 0.5f;
	public Transform player;
	float playerGroundPos;

	private void Awake ()
	{
		if (instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy (gameObject);
		}
	}

	private void Start ()
	{
		playerGroundPos = player.position.y;
		Fade (true);
	}

	public void Fade (bool isFadeIn)
	{
		if (isFadeIn) imgFade.CrossFadeAlpha (0, timeTeleport, true);
		else imgFade.CrossFadeAlpha (1, timeTeleport, true);
	}

	public void Teleport (Vector3 _newPos)
	{
		StartCoroutine ("MovePosition", _newPos);
	}

	IEnumerator MovePosition (Vector3 newPos)
	{
		// Lo vuelve negro
		Fade (false);
		yield return new WaitForSeconds (timeTeleport);
		player.position = new Vector3 (newPos.x, newPos.y + playerGroundPos, newPos.z);
		yield return new WaitForSeconds (timeTeleport);
		// Lo vuelve transparente
		Fade (true);
	}

}