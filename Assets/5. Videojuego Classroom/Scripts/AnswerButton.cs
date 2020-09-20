using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButton : MonoBehaviour
{
    public Color enterColor;
    public Color exitColor;
    Image imgButton;

    private void Awake()
    {
        imgButton = GetComponent<Image>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter()
    {
        Debug.Log("Enter");
        imgButton.color = enterColor;
    }

    public void OnPointerExit()
    {
        Debug.Log("Exit");
        imgButton.color = exitColor;
    }
}
