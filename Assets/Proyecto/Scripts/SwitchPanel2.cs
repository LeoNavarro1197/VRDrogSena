using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPanel2 : MonoBehaviour
{
    public GameObject firstCanvas;
    public GameObject secondCanvas;
    public GameObject thirdCanvas;
    public GameObject otherCanvas;

    public void ChangeCanvas()
    {
        secondCanvas.SetActive(true);
        firstCanvas.SetActive(false);
        thirdCanvas.SetActive(true);
        otherCanvas.SetActive(true);
    }
}
