using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGameplay : MonoBehaviour
{
    public AlphaNumerico alphaNumerico;
    public GameObject Agent;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (alphaNumerico.initNewState)
        {
            Invoke("InstanciarAgente", Random.Range(10, 15));
        }
    }

    void InstanciarAgente()
    {
        Agent.SetActive(true);
    }
}
