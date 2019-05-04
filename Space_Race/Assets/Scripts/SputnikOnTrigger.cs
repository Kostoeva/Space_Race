using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SputnikOnTrigger : MonoBehaviour {

    public GameObject textObject;

	// Use this for initialization
	void Start () {
        textObject.SetActive(false);
	}
	
	void OnTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Debug.Log("player collided with sputnik");

            textObject.SetActive(true);
            StartCoroutine("Wait");
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        textObject.SetActive(false);
    }
}
