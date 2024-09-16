using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class SwitchCanvas : MonoBehaviour, IPointerClickHandler
{

    public GameObject firstCanvas;
    public GameObject secondCanvas;
    public GameObject tarjetasProveedor;

    public GameObject canvas;

    public string firstCanvasTag, tarjetasProveedorTag, secondCanvasName, canvasComponent;

    AudioSource audioSource, audioSourcePerson;

    void Awake()
    {
        GameObject audioObject = GameObject.FindGameObjectWithTag("AudioCorrecto");

        audioSource = audioObject.GetComponent<AudioSource>();

        GameObject audioObjectPerson = GameObject.FindGameObjectWithTag("AudioProveedorCorrecto");

        audioSourcePerson = audioObjectPerson.GetComponent<AudioSource>();


        firstCanvas = GameObject.FindGameObjectWithTag(firstCanvasTag);
        tarjetasProveedor = GameObject.Find(tarjetasProveedorTag);
        //Obtener el padre
        canvas = GameObject.Find(canvasComponent);
        Transform parentTransform = canvas.transform;

        // Encontrar el GameObject desactivado en la jerarquía
        Transform transformSecondCanvas = parentTransform.Find(secondCanvasName);

        //Convertir a GameObject
        secondCanvas = transformSecondCanvas.gameObject;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        audioSource.Play();
        audioSourcePerson.Play();
        secondCanvas.SetActive(true);
        firstCanvas.SetActive(false);
        tarjetasProveedor.SetActive(false);
    }
}
