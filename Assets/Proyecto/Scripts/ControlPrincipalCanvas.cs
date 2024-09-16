using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPrincipalCanvas : MonoBehaviour
{
    public GameObject principalCanvas;

    public void ActiveCanvas()
    {
        principalCanvas.SetActive(true);
    }
}
