using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroText : MonoBehaviour {

    public Text welcome;

    void Start()
    {
        StartCoroutine(MyCoroutine());
    }

    IEnumerator MyCoroutine()
    {
        //This is a coroutine
        yield return new WaitForSeconds(10);

        welcome.enabled = false;
    }
}
