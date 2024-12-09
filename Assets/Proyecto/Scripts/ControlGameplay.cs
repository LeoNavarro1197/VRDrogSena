using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGameplay : MonoBehaviour
{
    public AlphaNumerico alphaNumerico;
    public GameObject Agent, Agent2, Agent3;
    public bool agent1 = false, agent2 = false, agent3 = false, agent4 = false, agent5 = false;
    bool bandera = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (alphaNumerico.initNewState && bandera)
        {
            Invoke("InstanciarAgente", Random.Range(10, 15));
            bandera = false;
        }
    }

    void InstanciarAgente()
    {
        int numeroAgente = Random.Range(1, 4);

        if(numeroAgente == 1)
        {
            Agent.SetActive(true);
            agent1 = true;
        }
        if(numeroAgente == 2)
        {
            Agent2.SetActive(true);
            agent2 = true;
        }
        if (numeroAgente == 3)
        {
            Agent3.SetActive(true);
            agent3 = true;
        }
    }
}
