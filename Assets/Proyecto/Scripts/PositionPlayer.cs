using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPlayer : MonoBehaviour
{
    public Transform positionPlayer, positionTeleportComputer;
    public GameObject colisionComputer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(positionPlayer.position.x == positionTeleportComputer.position.x && positionPlayer.position.z == positionTeleportComputer.position.z)
        {
            colisionComputer.SetActive(false);
        }
        else
        {
            colisionComputer.SetActive(true);
        }
    }
}
