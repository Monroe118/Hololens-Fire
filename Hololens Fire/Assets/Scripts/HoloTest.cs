using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoloTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnColor()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = new
            Color(Random.Range(0, 255) / 255f, Random.Range(0, 255) / 255f,
            Random.Range(0, 255) / 255f);

        Debug.Log("Color");
    }

    public void OnBig()
    {
        gameObject.GetComponent<Transform>().localScale = new 
            Vector3(1.5f, 1.5f, 1.5f);

        Debug.Log("Big");
    }

    public void OnSmall()
    {
        gameObject.GetComponent<Transform>().localScale = new 
            Vector3(0.5f, 0.5f, 0.5f);

        Debug.Log("Small");
    }
}
