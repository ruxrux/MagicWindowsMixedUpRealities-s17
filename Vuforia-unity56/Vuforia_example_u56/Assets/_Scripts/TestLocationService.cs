using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class TestLocationService : MonoBehaviour
{
	public Text info;
	private string debug;
	private bool bHasService = false;

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
		// Input.location.Start(float desiredAccuracyInMeters, float updateDistanceInMeters);
		// https://docs.unity3d.com/ScriptReference/LocationService.Start.html
		Input.location.Start(.1f, .1f);
		debug = ":: Loc services requested ::";
		//Debug.Log (debug);
		info.text = debug;

		// Wait until service initializes / if times out try longer times
		int maxWait = 2;
		while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
		{
			yield return new WaitForSeconds(1);
			maxWait--;
		}

		// Service didn't initialize in 5 seconds
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
			debug = ".: Location :. \nLat :: " + Input.location.lastData.latitude + "\nLon :: " + Input.location.lastData.longitude + "\nTSt :: " + Input.location.lastData.timestamp;
			//Debug.Log (debug);
			//debug = "got locations";
			info.text = debug;
			bHasService = true;
			
		}
			
		// Stop service if there is no need to query location updates continuously
		//Input.location.Stop();
	}

	public void UpdateLocation(){
		if (bHasService) {
			//yield return new WaitForSeconds (2);
			debug = ".: Location :. \nLat .: " + Input.location.lastData.latitude + "\nLon .: " + Input.location.lastData.longitude + "\nTiS .: " + Input.location.lastData.timestamp;
			//Debug.Log (debug);
			info.text = debug;
		}
	}

		
}