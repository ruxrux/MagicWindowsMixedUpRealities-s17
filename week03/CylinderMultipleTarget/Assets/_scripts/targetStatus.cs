using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class targetStatus : MonoBehaviour {

	private bool Target1, Target2 = false;
	private Vector3 Target1_POS, Target2_POS;
	//private Vector3 point = new Vector3[2];

	private LineRenderer line;
	// Use this for initialization
	void Start () {
		line = gameObject.AddComponent<LineRenderer> ();
		line.widthMultiplier = .02f;
		line.positionCount = 2;
		line.material = new Material (Shader.Find ("Mobile/Particles/Additive"));
		line.startColor = Color.blue;
		line.endColor = Color.red;
	}
	
	// Update is called once per frame
	void Update () {

		StateManager sm = TrackerManager.Instance.GetStateManager ();

		IEnumerable<TrackableBehaviour> allTrackables = sm.GetTrackableBehaviours ();

		foreach (TrackableBehaviour tb in allTrackables) {

			if (tb.CurrentStatus == TrackableBehaviour.Status.DETECTED ||
			   tb.CurrentStatus == TrackableBehaviour.Status.TRACKED) {

//				Debug.Log ("--> Trackable is  " + tb.TrackableName + " :: " + tb.CurrentStatus);
			}

			if (tb.TrackableName == "stones") {
				if (tb.CurrentStatus == TrackableBehaviour.Status.TRACKED) {
					Target1 = true;
					Target1_POS = tb.transform.position;
				} else {
					Target1 = false;
				}
				//Debug.Log ("---> Stones  " + Target1);

			}

			if (tb.TrackableName == "tarmac") {
				if (tb.CurrentStatus == TrackableBehaviour.Status.TRACKED) {
					Target2 = true;
					Target2_POS = tb.transform.position;
				} else {
					Target2 = false;
				}
				//Debug.Log ("---> Tarmac  " + Target2);

			}
		}

		if (Target1 == true && Target2 == true) {
			Debug.Log ("!! yay we're tracking 2 targets !!");
			line.enabled = true;
			var points = new Vector3[2];
			points [0] = Target1_POS;
			points [1] = Target2_POS;
			line.SetPositions (points);
		} else {
			line.enabled = false;
			Debug.Log ("!! nay we're NOT !!");

		}
	}
}
