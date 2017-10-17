using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//using System.Linq;
using Vuforia;

public class TargetStatus : MonoBehaviour {

	// ccreateing some vars to store the targets status and positions
	bool bTarget1, bTarget2 = false;
	Vector3 PosTarget1, PosTarget2;

	private LineRenderer line;

	void Start () {

		//create a line rendere object ad set its properties
		line = gameObject.AddComponent<LineRenderer>();
		line.widthMultiplier= 0.02f;
		line.positionCount = 2;
		line.material = new Material (Shader.Find ("Particles/Additive"));
		line.startColor = Color.white;
		line.endColor = Color.red;	
	}


	void Update() {

		// Get the StateManager
		StateManager sm = TrackerManager.Instance.GetStateManager ();

        // Query the StateManager to retrieve the list of
        // currently 'active' trackables 

		IEnumerable<TrackableBehaviour> allTrackables = sm.GetTrackableBehaviours ();


		foreach (TrackableBehaviour trackable in allTrackables) {

			if(trackable.CurrentStatus == TrackableBehaviour.Status.DETECTED ||
				trackable.CurrentStatus == TrackableBehaviour.Status.TRACKED ||
				trackable.CurrentStatus == TrackableBehaviour.Status.EXTENDED_TRACKED){

				Debug.Log("Trackable: " + trackable.TrackableName + " " + trackable.CurrentStatus );
			}

			// some logic to demonstrate what we can do with this data 
			// finding two specifc targets and getting their status and position

			if ( trackable.TrackableName == "chips" ) {
				if (trackable.CurrentStatus == TrackableBehaviour.Status.TRACKED) {
					bTarget1 = true;
					PosTarget1 = trackable.transform.position;


				} else {
					bTarget1 = false;
				}
			}

			if ( trackable.TrackableName == "tarmac" ) {
				if ( trackable.CurrentStatus == TrackableBehaviour.Status.TRACKED ) {
					bTarget2 = true;
					PosTarget2 = trackable.transform.position;	

					// more on Finding objects by name and especially important by tag!
					// https://docs.unity3d.com/ScriptReference/GameObject.Find.html
					// more on SendMessage :
					// https://docs.unity3d.com/ScriptReference/GameObject.SendMessage.html
					GameObject.Find ("Cube").SendMessage("rotate", 2.0f);

				} else {
					bTarget2 = false;
				}
			}

		}

		// if we're tracking two targets, draw a line between their positions
		if (bTarget1 && bTarget2) {

			line.enabled = true;
			Debug.Log ("got the two on!");
			var points = new Vector3[2];
			points [0] = PosTarget1;
			points [1] = PosTarget2;
			line.SetPositions (points);

		} else {
			
			line.enabled = false;
		}


	}
}
