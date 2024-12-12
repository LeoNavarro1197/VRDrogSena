using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecepcionTec : MonoBehaviour
{
    public GameObject objectToggle, audioCorrecto;
    public Transform uno, dos, tres, cuatro, cinco, seis, siete, ocho, nueve, diez, once;
    public Toggle toggle1, toggle2, toggle3, toggle4;
    bool bandera = true;

    // Start is called before the first frame update
    void Start()
    {
        int i = Random.Range(1, 12);

        if (i == 1) { objectToggle.transform.position = once.position; }
        else if (i == 2) { objectToggle.transform.position = diez.position; }
        else if (i == 3) { objectToggle.transform.position = nueve.position; }
        else if (i == 4) { objectToggle.transform.position = ocho.position; }
        else if (i == 5) { objectToggle.transform.position = siete.position; }
        else if (i == 6) { objectToggle.transform.position = seis.position; ; }
        else if (i == 7) { objectToggle.transform.position = cinco.position; }
        else if (i == 8) { objectToggle.transform.position = cuatro.position; }
        else if (i == 9) { objectToggle.transform.position = tres.position; }
        else if (i == 10) { objectToggle.transform.position = dos.position; }
        else if (i == 11) { objectToggle.transform.position = uno.position; }


    }

    // Update is called once per frame
    void Update()
    {
        if ((toggle1.isOn && (toggle2.isOn || toggle3.isOn || toggle4.isOn)) && bandera)
        {
            bandera = false;
            audioCorrecto.SetActive(true);
        }
    }
}
