using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPrincipalCanvas : MonoBehaviour
{
    public GameObject principalCanvas, colliderLavamanos;

    public void ActiveCanvas()
    {
        principalCanvas.SetActive(true);
        Invoke("DesactivarCollider", 1);
    }

    void DesactivarCollider()
    {
        colliderLavamanos.SetActive(false);
    }
}
