using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SputnikOnTrigger : MonoBehaviour {

    public GameObject textObject;
    public Text HUDText;

	// Use this for initialization
	void Start () {
        textObject.SetActive(false);
	}
	
	void OnTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Debug.Log("player collided with sputnik");

            StartCoroutine("Wait");
        }
    }

    IEnumerator Wait()
    {
        //yield return new WaitForSeconds(5);

        HUDText.text = "Text changed";
        yield return new WaitForSeconds(5);

    }
}
