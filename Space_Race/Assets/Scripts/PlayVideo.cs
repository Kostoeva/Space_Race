using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayVideo : MonoBehaviour {

    public GameObject videoPlayer;
    public int timeTillStop;

	// Use this for initialization
	void Start () {
        // Prevent from playing right away
        videoPlayer.SetActive(false);
		
	}
	
	// On collision
	void OnTriggerEnter (Collider player)
    {
        // If collided with "Player"
        if (player.gameObject.tag == "Player")
        {
            Debug.Log("player collided with Gagarin");
            // Start video.
            videoPlayer.SetActive(true);
            Destroy(videoPlayer, timeTillStop);
        }
    }
}
