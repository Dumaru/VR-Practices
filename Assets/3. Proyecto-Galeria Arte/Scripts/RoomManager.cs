using UnityEngine;

namespace ArtGalley{

	public class RoomManager : MonoBehaviour
	{
		[Header("Rooms")]
		public GameObject[] rooms;
		int lastRoom;

		private void Start()
		{
			foreach (GameObject room in rooms)
			{
				room.SetActive(false);
			}

			ChangeRoom(0);
		}

		public void ChangeRoom(int ID)
		{
			rooms[lastRoom].SetActive(false);
			rooms[ID].SetActive(true);

			lastRoom = ID;
		}


	}

}