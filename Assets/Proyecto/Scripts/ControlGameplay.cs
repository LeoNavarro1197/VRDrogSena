using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGameplay : MonoBehaviour
{
    public AlphaNumerico alphaNumerico;
    public GameObject Agent;
    public bool agent1 = false, agent2 = false, agent3 = false, agent4 = false, agent5 = false;

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
        int numeroAgente = Random.Range(1, 1);

        if(numeroAgente == 1)
        {
            Agent.SetActive(true);
            agent1 = true;
        }
        /*else if(numeroAgente == 2)
        {

        }*/
    }
}
