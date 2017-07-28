using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampbellJ_BackgroundMusic : MonoBehaviour {

    public AudioClip impact;
    new AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        audio.PlayOneShot(impact, 0.7f);
    }
}
