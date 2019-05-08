using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGIF : MonoBehaviour {

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(GIF());
    }

    IEnumerator GIF()
    {
        int ind = 0;
        string name = "laika-gif/frame_00_delay-0.1s";
        for (int i = 0; i < 10; i++)
        {
            Debug.Log(name);
            name = name.Substring(0, 17) + ind.ToString() + name.Substring(18);
            GetComponent<Renderer>().material.SetTexture("_MainTex", Resources.Load("laika-gif/frame_00_delay-0.1s") as Texture);
            yield return new WaitForSeconds(0.1f);
            ind++;
        }
    }
}
