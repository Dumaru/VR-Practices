using UnityEngine;
using TMPro;
namespace GUI_VR
{

    public class DialogBubble : MonoBehaviour
    {
        public string dialogText;
        public TextMeshProUGUI txtDialogBubble;
        public GameObject dialogBubble;


        void Start()
        {
            txtDialogBubble.text = dialogText;
            Pointer_Exit();
        }

        public void Pointer_Enter()
        {
            dialogBubble.SetActive(true);
        }

        public void Pointer_Exit()
        {
            dialogBubble.SetActive(false);
        }


    }

}