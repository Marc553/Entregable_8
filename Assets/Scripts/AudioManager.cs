using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] cancion;
    
    public int cancionActual;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(cancion[cancionActual]);
    }

    void Update()
    {
        
    }

    public void AvCancion()
    {
        cancionActual++;
    }
 


}
