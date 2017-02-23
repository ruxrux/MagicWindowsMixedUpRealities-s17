using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// make sure we have a audiosource component attached to the object
[RequireComponent(typeof(AudioSource))]

public class RotateAndPlaySound : MonoBehaviour {

	void Start(){
		// create an audio source object to get the component into the script
		AudioSource sampleBeats = GetComponent<AudioSource>();
		// use it to Play or control the sound
		sampleBeats.Play();

	}
	// Update is called once per frame
	void Update () {
		// animate rotation
		transform.Rotate (0f, Time.deltaTime *50f, 0f, Space.World);
	}
}
