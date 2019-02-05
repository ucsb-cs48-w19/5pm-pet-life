using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOnClick : MonoBehaviour
{
    public Text displayText;
    private bool isclicked = false;
    // Create a bool to say whether to show the button or not

    public void OnMouseDown()
    {
        if (!isclicked)
            isclicked = true;
        // If you clicked the object, set showText to true
    }

    public void OnMouseUp()
    {
        isclicked = false;
    }

    public void DisplayText()
    {
        if (isclicked)
        {
            displayText.text = "WOof";
          
        }
            
    }
}
