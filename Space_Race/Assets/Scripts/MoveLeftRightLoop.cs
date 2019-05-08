using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRightLoop : MonoBehaviour {

    public int maxValue = 15; 
    public int minValue = -15; 
    float currentValue = 0; 
    int direction = 1;

    // Use this for initialization
    void Start () {
        currentValue = transform.position.x;
    }
	
	// Update is called once per frame
	void Update () {
        currentValue += Time.deltaTime * direction; 
        if (currentValue >= maxValue)
        {
            direction *= -1;
            currentValue = maxValue;
        }
        else if (currentValue <= minValue)
        {
            direction *= -1;
            currentValue = minValue;
        }
        transform.position = new Vector3(currentValue, transform.position.y, transform.position.z);
    }
}
