using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TestLocationService : MonoBehaviour
{
	public Text info;
	private string debug;

	IEnumerator Start()
	{
		// First, check if user has location service enabled
		if (!Input.location.isEnabledByUser) {
			debug = "Loc disabled";
			//Debug.Log (debug);
			info.text = debug;

			yield break;
		}
		// Start service before querying location
		Input.location.Start();
		debug = ":: Loc services requested ::";
		//Debug.Log (debug);
		info.text = debug;
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
			debug = "Timed out";
			//Debug.Log (debug);
			info.text = debug;
			yield break;
		}

		// Connection has failed
		if (Input.location.status == LocationServiceStatus.Failed)
		{
			debug = "Unable to determine device location";
			//Debug.Log (debug);
			info.text = debug;
			yield break;
		}
		else
		{
			// Access granted and location value could be retrieved
			debug = "Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp;
			//Debug.Log (debug);
			info.text = debug;
			
		}


		// Stop service if there is no need to query location updates continuously
		Input.location.Stop();
	}
}