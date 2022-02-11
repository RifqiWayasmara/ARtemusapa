using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void GoTomenu()
    {
        Application.LoadLevel("menu");
    }

    public void GoToar()
    {
        Application.LoadLevel("ar");
    }

    public void GoToabout()
    {
        Application.LoadLevel("about");
    }

    public void GoTohelp()
    {
        Application.LoadLevel("help");
    }

    public void GoToexit()
    {
        Application.Quit();
    }
}
