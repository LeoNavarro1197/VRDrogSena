using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorFreeze : MonoBehaviour
{

    public Animation animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenDoor()
    {
        animator.enabled = true;
    }
}
