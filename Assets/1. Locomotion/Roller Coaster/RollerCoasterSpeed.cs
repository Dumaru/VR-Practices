using Cinemachine;
using UnityEngine;

namespace ArtGalley {
	public class RollerCoasterSpeed : MonoBehaviour
	{
		[Header("Dolly Cart")]
		public CinemachineDollyCart m_CinemachineDollyCart;
		[Range(.1f, 10f)] public float speedFast = 5;
		[Range(.1f, 10f)] public float speedNormal = 2.5f;
		[Range(.1f, 10f)] public float speedSlow = .5f;

		public void DollyCart_Fast()
		{
			m_CinemachineDollyCart.m_Speed = speedFast;
		}

		public void DollyCart_Normal()
		{
			m_CinemachineDollyCart.m_Speed = speedNormal;
		}

		public void DollyCart_Slow()
		{
			m_CinemachineDollyCart.m_Speed = speedSlow;
		}

		private void Update()
		{
			if (Input.GetKeyDown(KeyCode.F)) DollyCart_Fast();
			if (Input.GetKeyDown(KeyCode.N)) DollyCart_Normal();
			if (Input.GetKeyDown(KeyCode.S)) DollyCart_Slow();
		}

	}
}