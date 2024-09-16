using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioIncorrectoProveedor : MonoBehaviour
{
    AudioSource audioSourcePerson;

    // Start is called before the first frame update
    void Awake()
    {
        GameObject audioObject = GameObject.FindGameObjectWithTag("AudioIncorrecto");

        audioSourcePerson = audioObject.GetComponent<AudioSource>();
    }

    public void AudioIncorrecto()
    {
        audioSourcePerson.Play();
    }
}
