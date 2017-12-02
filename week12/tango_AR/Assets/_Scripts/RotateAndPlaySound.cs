using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// make sure we have a audiosource component attached to the object
[RequireComponent(typeof(AudioSource))]

public class RotateAndPlaySound : MonoBehaviour {
	
	private AudioSource sampleBeats;

	void Start(){
		// create an audio source object to get the component into the script
		sampleBeats = GetComponent<AudioSource>();
	}

	void PlayAndDance () {
		// animate rotation on Y axis
		transform.Rotate (0f, Time.deltaTime * 50f, 0f, Space.World);

		// use it to Play or control the sound
		if (!sampleBeats.isPlaying) {
			sampleBeats.Play ();
		}
	}

}
