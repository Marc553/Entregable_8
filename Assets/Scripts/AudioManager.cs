using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip[] cancion;
    public string[] nombre;
    
    public int cancionActual;
    public TextMeshProUGUI nombreCan;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(cancion[cancionActual]);
        nombreCan.text = $"{nombre[cancionActual]}";
    }

    public void AvCan()
    {
        audioSource.Stop();

        cancionActual++;
        if(cancionActual == 7)
        {
            cancionActual = 0;
        }
        audioSource.PlayOneShot(cancion[cancionActual]);
        nombreCan.text = $"{nombre[cancionActual]}";
    }

    public void ReCan()
    { 
        audioSource.Stop();
        cancionActual--;
        
        if(cancionActual == -1)
        {
            cancionActual = 6;
        }
        audioSource.PlayOneShot(cancion[cancionActual]);
        nombreCan.text = $"{nombre[cancionActual]}";
    }
    
    public void Pausa()
    {
        audioSource.Pause();
    }
    public void Play()
    {
        audioSource.UnPause();
    }
    
    public void RandomCan()
    {
        audioSource.Stop();
        int randomcan = Random.Range(0, cancion.Length);
        cancionActual = randomcan;
        audioSource.PlayOneShot(cancion[cancionActual]);
        nombreCan.text = $"{nombre[cancionActual]}";

    }
}
