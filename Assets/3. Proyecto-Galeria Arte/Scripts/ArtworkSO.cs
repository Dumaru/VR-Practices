using UnityEngine;

namespace ArtGalley {

	[CreateAssetMenu(fileName = "New Artwork", menuName = "Scriptable Object/New Artwork", order = 0)]
	public class ArtworkSO : ScriptableObject
	{
		public Texture[] artworks;
	}
}