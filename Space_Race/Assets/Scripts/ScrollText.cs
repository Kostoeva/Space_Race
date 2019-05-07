using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollText : MonoBehaviour {

    public float speed = 20;
	
	// Update is called once per frame
	void Update () {
        // Get current pos of parent.
        Vector3 currPos = transform.position;

        // Get vector direction.
        Vector3 localDirectionUp = transform.TransformDirection(0, 1, 0);

        // Scroll text upward.
        currPos += localDirectionUp * speed * Time.deltaTime;
        transform.position = currPos;
	}
}
