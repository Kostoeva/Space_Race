using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypewriterUI : MonoBehaviour {

    public Text HUDtext;
    public Text inputText;

    // Actually seen on UI.
    private string outputString = null;
    private int i = -1;
    private bool done;

	// Update is called once per frame
	void Update () {
		if (!done)
        {
            HUDtext.text = Typewrite(inputText.text);
        }
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
