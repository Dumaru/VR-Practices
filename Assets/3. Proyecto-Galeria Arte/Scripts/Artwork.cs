using UnityEngine;

namespace ArtGalley {

	public class Artwork : MonoBehaviour
	{
		[Header("Artworks")]
		public ArtworkSO artworkSO;
		private int materialId = 1;
		MeshRenderer[] artworks;

		private void Start()
		{
			artworks = GetComponentsInChildren<MeshRenderer>();
			SetArtworks();
		}

		private void SetArtworks()
		{
			for (int i = 0; i < artworks.Length; i++)
			{
				artworks[i].materials[materialId].mainTexture = artworkSO.artworks[i];
			}
		}

	}
}