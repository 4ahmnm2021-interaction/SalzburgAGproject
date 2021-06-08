using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VentilSound : MonoBehaviour
{

    public AudioClip Ventil;
    public AudioSource audios;

    public void VentilSounds()
    {
        audios.PlayOneShot(Ventil);
    }
}
