using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class soundPlayer : MonoBehaviour {


	void Play () {
		AudioSource sample = GetComponent<AudioSource> ();

		if (!sample.isPlaying) {
			sample.Play ();
		}
	}

}


