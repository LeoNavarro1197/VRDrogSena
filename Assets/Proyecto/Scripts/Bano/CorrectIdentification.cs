using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectIdentification : MonoBehaviour
{
    public GameObject UnoInit, UnoFinal;
    public GameObject DosInit, DosFinal;
    public GameObject TresInit, TresFinal;
    public GameObject CuatroInit, CuatroFinal;
    public GameObject CincoInit, CincoFinal;
    public GameObject SeisInit, SeisFinal;
    public GameObject SieteInit, SieteFinal;
    public GameObject OchoInit, OchoFinal;
    public GameObject NueveInit, NueveFinal;
    public GameObject DiezInit, DiezFinal;
    public GameObject OnceInit, OnceFinal;


    bool UnoState = false, DosState = false, TresState = false, CuatroState = false, CincoState = false, SeisState = false, SieteState = false, OchoState = false,
          NueveState = false, DiezState = false, OnceState = false;

    public bool equationCorrect = false;

    public GameObject audioSource;

    void Update()
    {
        if (UnoInit.transform.position == UnoFinal.transform.position) { UnoState = true; }
        if (DosInit.transform.position == DosFinal.transform.position) { DosState = true; }
        if (TresInit.transform.position == TresFinal.transform.position) { TresState = true; }
        if (CuatroInit.transform.position == CuatroFinal.transform.position) { CuatroState = true; }
        if (CincoInit.transform.position == CincoFinal.transform.position) { CincoState = true; }
        if (SeisInit.transform.position == SeisFinal.transform.position) { SeisState = true; }
        if (SieteInit.transform.position == SieteFinal.transform.position) { SieteState = true; }
        if (OchoInit.transform.position == OchoFinal.transform.position) { OchoState = true; }
        if (NueveInit.transform.position == NueveFinal.transform.position) { NueveState = true; }
        if (DiezInit.transform.position == DiezFinal.transform.position) { DiezState = true; }
        if (OnceInit.transform.position == OnceFinal.transform.position) { OnceState = true; }

        if (UnoState && DosState && TresState && CuatroState && CincoState && SeisState && SieteState && OchoState && NueveState && DiezState && OnceState)
        {
            equationCorrect = true;
        }

        if (equationCorrect)
        {
            audioSource.SetActive(true);
        }
    }
}
