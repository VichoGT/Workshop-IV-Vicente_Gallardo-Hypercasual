using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;



public class MenuOpciones : MonoBehaviour
{
    [SerializeField] private AudioMixer audiomixer;  

    public void CambiarVolumen(float volumen)
    {
        audiomixer.SetFloat("Volume",volumen);
    }
}
