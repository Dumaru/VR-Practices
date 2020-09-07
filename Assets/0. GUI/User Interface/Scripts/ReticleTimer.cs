using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

namespace GUI_VR
{
    public class ReticleTimer : MonoBehaviour
    {
        [Header("Timer")]
        public Image imgTimer;
        [Range(0f, 5f)] public float timeTotal = 1;

        [Header("Events")]
        public UnityEvent[] timerEvents;

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
                imgTimer.fillAmount = timeCurrent / timeTotal;

                if (timeCurrent >= timeTotal)
                {
                    isEnable = false;
                    timerEvents[idEvent].Invoke();
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
            imgTimer.fillAmount = 0;
            timeCurrent = 0;
        }

    }
}