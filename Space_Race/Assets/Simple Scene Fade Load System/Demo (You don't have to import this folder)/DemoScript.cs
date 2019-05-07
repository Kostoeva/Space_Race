using UnityEngine;
using System.Collections;

public class DemoScript : MonoBehaviour {
    //name of the scene you want to load
    public string scene;
	public Color loadToColor = Color.white;

    void Start()
    {
        StartCoroutine(WaitTillDone());
    }

    IEnumerator WaitTillDone()
    {
        yield return new WaitForSeconds(23);
        GoFade();
    }


    public void GoFade()
    {
        Initiate.Fade(scene, loadToColor, 1.0f);
    }
}
