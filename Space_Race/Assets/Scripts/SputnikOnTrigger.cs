using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SputnikOnTrigger : MonoBehaviour {

    public Text HUDtext;
    public Text inputText;

    // Actually seen on UI.
    private string outputString = null;
    private int i = -1;
    private bool done = false;
    private bool triggered = false;

    // Update is called once per frame
    void Update()
    {
        while(!triggered)
        {

        }

        if (!done)
        {
            HUDtext.text = Typewrite(inputText.text);
        }
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
        HUDtext.text = "Text changed";
        yield return new WaitForSeconds(5);

    }

    private string Typewrite(string text)
    {
        i++;
        char[] characterArray = text.ToCharArray();
        outputString = outputString + characterArray[i].ToString();
        if (i == (characterArray.Length - 1))
        {
            done = true;
        }
        return outputString;
    }
}
