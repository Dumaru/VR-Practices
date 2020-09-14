using System.Collections;
using Cinemachine;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
namespace Education
{

    public class TimelineManager : MonoBehaviour
    {
        [Header("Timeline")]
        public int actualInteraction = 0;
        public int[] interactionPoints;
        public TimelineAsset[] timelineAssets;

        [Header("Complete")]
        public PlayableDirector playableDirector;
        public CinemachineDollyCart cart;
        public CinemachineSmoothPath path;

        private void Start()
        {
            Play();
        }

        public void Play()
        {
            StartCoroutine(PlayTimeline());
        }

        IEnumerator PlayTimeline()
        {
            Debug.Log("<b>" + "START" + "</b>");
            while (actualInteraction < interactionPoints.Length)
            {
                if (cart.m_Position > interactionPoints[actualInteraction])
                {
                    Debug.Log("Step: " + actualInteraction.ToString());
                    playableDirector.playableAsset = timelineAssets[actualInteraction];
                    playableDirector.Play();
                    actualInteraction++;
                }
                yield return null;
            }
            Debug.Log("<b>" + "WAITING" + "</b>");
            while (cart.m_Position < path.PathLength)
            {
                yield return null;
            }
            Debug.Log("<b>" + "END" + "</b>");
        }

    }
}