using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header ("Source")]

    public AudioSource MusicSource;
    public AudioSource SFXSource;

    [Header("Clip")]

    public AudioClip MusicBackground;
    public AudioClip bottons;


    private void Start()
    {
        MusicSource.clip = MusicBackground;
        MusicSource.Play();
    }

    public void HoverSound (AudioClip clip)
    {
        SFXSource.PlayOneShot(bottons);
    }

    public void ClickSound(AudioClip clip)
    {
        SFXSource.PlayOneShot(bottons);
    }


}
