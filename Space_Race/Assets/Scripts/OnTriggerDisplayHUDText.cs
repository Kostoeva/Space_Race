using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnTriggerDisplayHUDText : MonoBehaviour {

    public Text HUDtext;

    private bool triggered = false;

    void Update()
    {
        if (triggered)
        {
            HUDtext.gameObject.SetActive(true);
        } else
        {
            HUDtext.gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            Debug.Log("player collided with sputnik");
            triggered = true;
        }
    }

    void OnTriggerExit (Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            triggered = false;
        }
    }



}
