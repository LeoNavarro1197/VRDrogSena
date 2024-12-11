using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecepcionAdmin : MonoBehaviour
{
    public GameObject neveras, medicamnetos, estiba, uiFactura, uiOrden, uiExplicaionTecnica, uiRecepcionTecnica, audioCorrecto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RecepcionAdminnistrativa()
    {
        neveras.SetActive(false);
        medicamnetos.SetActive(false); 
        estiba.SetActive(false); 
        uiFactura.SetActive(false);
        uiOrden.SetActive(false);
        uiExplicaionTecnica.SetActive(true);
        uiExplicaionTecnica.SetActive(true);
        audioCorrecto.SetActive(true);
    }
}
