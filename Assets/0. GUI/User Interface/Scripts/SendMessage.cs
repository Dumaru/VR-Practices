using UnityEngine;

namespace GUI_VR
{
    public class SendMessage : MonoBehaviour
    {

        public void Pointer_Enter()
        {
            Debug.Log("<color=green><b>" + "ENTER" + "</b></color>");
        }

        public void Pointer_Exit()
        {
            Debug.Log("<color=red><b>" + "EXIT" + "</b></color>");
        }

        public void Pointer_Click()
        {
            Debug.Log("<b>" + "Click" + "</b>");
        }
    }

}