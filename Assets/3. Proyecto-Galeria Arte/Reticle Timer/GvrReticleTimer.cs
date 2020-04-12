using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ArtGalley
{

    public class GvrReticleTimer : MonoBehaviour
    {
        [System.Serializable]
        public class TimerEvent : UnityEvent<int> { }

        [Header("Timer")]
        public Image imgReticle;
        [Range(0f, 5f)] public float timeTotal = 1;

        [Header("Events")]
        public TimerEvent[] timerEvents;

        int idEvent;
        float timeCurrent;
        bool isEnable;

        void Start()
        {
            Timer_Exit();
        }

        void Update()
        {
            Timer();
        }

        private void Timer()
        {
            if (isEnable)
            {
                timeCurrent += Time.deltaTime;
                imgReticle.fillAmount = timeCurrent / timeTotal;

                if (timeCurrent >= timeTotal)
                {
                    Timer_Exit();
                    timerEvents[idEvent].Invoke(idEvent);
                }
            }
        }

        public void Timer_Enter(int _ID)
        {
            isEnable = true;
            idEvent = _ID;
        }

        public void Timer_Exit()
        {
            isEnable = false;
            imgReticle.fillAmount = 0;
            timeCurrent = 0;
        }

    }
}