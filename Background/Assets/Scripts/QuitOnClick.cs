using UnityEngine;
using System.Collections;

public class QuitOnClick : MonoBehaviour
{

    public void Quit()
    {
        //exit play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }

}