using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ActiveEquation : MonoBehaviour
{
    public GameObject PRInit, PRFinish;
    public GameObject CMPInit, CMPFinish;
    public GameObject MultiplicatorInit, MultiplicatorFinish;
    public GameObject SubstractionInit, SubstractionFinish;
    public GameObject ExisInit, ExisFinish;
    public GameObject videoAlphaNumerico;

    bool PRState = false, CMPState = false, MultiplicatorState = false, SubstractionState = false, ExisState = false;
    public bool equationCorrect = false;

    public GameObject dragAndDrop, alphaNumerico;

    public GameObject audioSource;

    void Update()
    {
        if (PRInit.transform.position == PRFinish.transform.position) { PRState = true; }
        if (CMPInit.transform.position == CMPFinish.transform.position) { CMPState = true; }
        if (MultiplicatorInit.transform.position == MultiplicatorFinish.transform.position) { MultiplicatorState = true; }
        if (SubstractionInit.transform.position == SubstractionFinish.transform.position) { SubstractionState = true; }
        if (ExisInit.transform.position == ExisFinish.transform.position) { ExisState = true; }

        if(PRState &&  CMPState && MultiplicatorState && SubstractionState && ExisState)
        {
            equationCorrect = true;
        }

        if(equationCorrect)
        {
            audioSource.SetActive(true);
            dragAndDrop.SetActive(false);
            alphaNumerico.SetActive(true);
            videoAlphaNumerico.SetActive(true);
        }
    }
}
