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

    bool f1 = true, f2 = true, f3 = true, f4 = true, f5 = true, f6 = true, f7 = true, f8 = true, f9 = true, f10 = true, f11 = true;
    bool UnoState, DosState, TresState, CuatroState, CincoState, SeisState, SieteState, OchoState, NueveState, DiezState, OnceState;

    public bool equationCorrect = false;

    public GameObject audioSource;
    public GameObject juegoBano, congratsBano;

    void Update()
    {
        if (UnoInit.transform.position == UnoFinal.transform.position && f1) { UnoState = true; f1 = false; Debug.Log("1"); }
        if (DosInit.transform.position == DosFinal.transform.position && f2) { DosState = true; f2 = false; Debug.Log("2"); }
        if (TresInit.transform.position == TresFinal.transform.position && f3) { TresState = true; f3 = false; Debug.Log("3"); }
        if (CuatroInit.transform.position == CuatroFinal.transform.position && f4) { CuatroState = true; f4 = false; Debug.Log("4"); }
        if (CincoInit.transform.position == CincoFinal.transform.position && f5) { CincoState = true; f5 = false; Debug.Log("5"); }
        if (SeisInit.transform.position == SeisFinal.transform.position && f6) { SeisState = true; f6 = false; Debug.Log("6"); }
        if (SieteInit.transform.position == SieteFinal.transform.position && f7) { SieteState = true; f7 = false; Debug.Log("7"); }
        if (OchoInit.transform.position == OchoFinal.transform.position && f8) { OchoState = true; f8 = false; Debug.Log("8"); }
        if (NueveInit.transform.position == NueveFinal.transform.position && f9) { NueveState = true; f9 = false; Debug.Log("9"); }
        if (DiezInit.transform.position == DiezFinal.transform.position && f10) { DiezState = true; f10 = false; Debug.Log("10"); }
        if (OnceInit.transform.position == OnceFinal.transform.position && f11) { OnceState = true; f11 = false; Debug.Log("11"); }

        if (UnoState && DosState && TresState && CuatroState && CincoState && SeisState && SieteState && OchoState && NueveState && DiezState && OnceState)
        {
            equationCorrect = true;
        }

        if (equationCorrect)
        {
            audioSource.SetActive(true);
            juegoBano.SetActive(false);
            congratsBano.SetActive(true);
        }
    }
}
