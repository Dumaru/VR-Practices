using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Inmobiliaria {

    public class MyGameManager : MonoBehaviour
    {
        [SerializeField]
        private Image imgFade;
        // Start is called before the first frame update
        void Start()
        {
            // Invokes method after 1 second
            Invoke("Fade", 1);
        }

        private void Fade()
        {
            // In becomes transparent after 2 second no matter the timescale
            imgFade.CrossFadeAlpha(0, 1, true);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}