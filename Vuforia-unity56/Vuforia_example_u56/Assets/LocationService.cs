using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationService : MonoBehaviour {

	public float lat;
	public float lon;
	public double tSt;
	public Text	debugInfo;
	private bool hasService = false;

	// Use this for initialization
	void Start () {
		StartCoroutine (StartLocationService());
	}

	void Update(){
		StartCoroutine (UpdateLocationService ());
	}
		
	private IEnumerator StartLocationService(){
	
		if(!Input.location.isEnabledByUser){
			debugInfo.text = "user has not given permissions";
			yield break;
		}

		Input.location.Start (0.1f,0.1f);
		int maxWait = 20;
		while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0) {

			yield return new WaitForSeconds (1);
			maxWait--;
		}

		if(maxWait <= 0){
			debugInfo.text = "Timed Out";
			yield break;
		}

		if(Input.location.status == LocationServiceStatus.Failed){
			debugInfo.text = "Unable to determine location";
			yield break;
		}

		lat = Input.location.lastData.latitude;
		lon = Input.location.lastData.longitude;
		tSt = Input.location.lastData.timestamp;
		debugInfo.text = ".:Loc:. \n" + lat + "\n" + lon + "\n"+tSt;
		hasService = true;

		yield break;
	}

	private IEnumerator UpdateLocationService(){
		while(hasService){
			yield return new WaitForSeconds (2);
			lat = Input.location.lastData.latitude;
			lon = Input.location.lastData.longitude;
			tSt = Input.location.lastData.timestamp;
			debugInfo.text = ".:Loc:. \n" + lat + "\n" + lon + "\n"+tSt + "\n" + Time.time;

		}
	}
}
