using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionPlayAudio : MonoBehaviour {

    private AudioSource audioSource;
    public AudioClip audio;

    void OnTriggerEnter (Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("collided play sound");
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = audio;
            audioSource.Play();
        }
    }
}
