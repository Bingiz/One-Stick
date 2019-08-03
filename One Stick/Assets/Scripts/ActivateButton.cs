using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateButton : MonoBehaviour
{
    public UnityEngine.Events.UnityEvent ButtonPress;
    public UnityEngine.Events.UnityEvent ButtonRelease;

    public void Activate()
    {
        ButtonPress.Invoke();
        Debug.Log("Button is Pressed");
    }

    public void Deactivate()
    {
        ButtonRelease.Invoke();
        Debug.Log("Button is Released");
    }
}
