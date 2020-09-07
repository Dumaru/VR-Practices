using UnityEngine;

namespace GUI_VR
{

    [RequireComponent(typeof(CanvasGroup))]
    public class CanvasInside : MonoBehaviour
    {
        [Range(0, 5)]
        public float fadeDuration = 1f;
        float alpha = 0;
        Camera m_Camera;
        CanvasGroup m_CanvasGroup;

        private void Awake()
        {
            m_Camera = Camera.main;
            m_CanvasGroup = GetComponent<CanvasGroup>();
        }

        void Update()
        {
            LookToPlayer();
            FadeWhenLook();
        }

        private void LookToPlayer()
        {
            // Camera helper vectors
            Vector3 lookUpDir = (m_Camera.transform.up + m_Camera.transform.forward) / 2;  // Up and Forward divided by 2
            Vector3 forwardDir = new Vector3(lookUpDir.x, 0, lookUpDir.z);
            forwardDir.Normalize();

            // Baja y corre adelante
            transform.position = m_Camera.transform.position - 1.5f * Vector3.up + forwardDir;

            Vector3 toCameraVec = m_Camera.transform.position - transform.position;
            float camDist = toCameraVec.magnitude;
            if (camDist > m_Camera.nearClipPlane)
                transform.rotation = Quaternion.LookRotation(m_Camera.transform.forward,
                                     m_Camera.transform.up);
        }

        private void FadeWhenLook()
        {
            Vector2 vp = m_Camera.WorldToViewportPoint(transform.position);
            if (vp.x > 0.2f && vp.x < 0.8f && vp.y > 0.2f && vp.y < 0.8f)
            {
                if (alpha < 1)
                    alpha += Time.deltaTime / fadeDuration;
            }
            else
            {
                if (alpha > 0)
                    alpha -= Time.deltaTime / fadeDuration;
            }

            alpha = Mathf.Clamp01(alpha);
            m_CanvasGroup.alpha = alpha;
        }

    }

}