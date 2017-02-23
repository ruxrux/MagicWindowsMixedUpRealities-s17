using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// to make sure we have an audio component!
[RequireComponent(typeof(AudioSource))]


public class rotate_self : MonoBehaviour {


	void Start(){
		// we get the suio source compnent and then play it!
		AudioSource sample = GetComponent<AudioSource> ();
//		sample.spatialBlend = 1f;
//		sample.spatialize = true;
		sample.Play ();

	}
	// Update is called once per frame
	void Update () {
		// two different ways of doing the same rotation
		// 1: choose the vector direction for axis (up = vertical = y)
		transform.Rotate (Vector3.up, Time.deltaTime *20, Space.World);
		// 2: set each axys with a value 
		//transform.Rotate (0f, Time.deltaTime *20, 0f, Space.World);	

	}
}


/*
public class ExampleClass : MonoBehaviour {
    void Start() {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
    }


*/