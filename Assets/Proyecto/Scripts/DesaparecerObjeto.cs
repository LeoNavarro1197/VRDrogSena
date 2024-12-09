using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesaparecerObjeto : MonoBehaviour
{
    public GameObject objeto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Bandeja"))
        {
            Debug.Log("entro bandeja");
            Invoke("DestruirObjeto", 1f);
        }
    }

    void DestruirObjeto()
    {
        objeto.SetActive(false);
    }
}
