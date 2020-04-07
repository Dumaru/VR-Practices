using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Inmobiliaria {

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

        /// <summary>
        /// Starts timer when the reticle points an interactable object
        /// </summary>
        /// <param name="_ID"></param>
        public void Timer_Enter(int _ID)
        {
            isEnable = true;
            idEvent = _ID;
        }

        /// <summary>
        /// Stops the timer when the reticle stops pointing an interactable object
        /// </summary>
        public void Timer_Exit()
        {
            isEnable = false;
            imgReticle.fillAmount = 0;
            timeCurrent = 0;
        }

    }
}