using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class getLocation : MonoBehaviour
{
	public static getLocation Instance { set; get; }

	public Text debug;
	public double lat, lon, time;
	bool bGotData = false;

	private void Start(){

		Instance = this;

		StartCoroutine (StartLocationServices ());
	}

	IEnumerator StartLocationServices()
	{
		// First, check if user has location service enabled
		if (!Input.location.isEnabledByUser)
			yield break;

		// Start service before querying location
		Input.location.Start();

		// Wait until service initializes
		int maxWait = 20;
		while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
		{
			yield return new WaitForSeconds(1);
			maxWait--;
		}

		// Service didn't initialize in 20 seconds
		if (maxWait < 1)
		{
			print("Timed out");
			yield break;
		}

		// Connection has failed
		if (Input.location.status == LocationServiceStatus.Failed)
		{
			print("Unable to determine device location");
			yield break;
		}
		else
		{
			// Access granted and location value could be retrieved
			print("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);
			lat = Input.location.lastData.latitude;
			lon = Input.location.lastData.longitude;
			time = Input.location.lastData.timestamp;
			bGotData = true;
		}

	
	}

	private void Update(){
		
		if (bGotData) {
			lat = Input.location.lastData.latitude;
			lon = Input.location.lastData.longitude;
			time = Input.location.lastData.timestamp;
			debug.text = lat.ToString () + "\n" + lon.ToString () + "\n" + time.ToString ();
		}
	}
}

