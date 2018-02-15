using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using SimpleJSON;

public class GETrequest : MonoBehaviour {


	string location;
	string weather;

	public GameObject[] weatherIcons;// = new GameObject[2];
	private GameObject myWeather;
	private bool bHasWeather = false;

	void Start() {
		StartCoroutine(GetText());
	}

	IEnumerator GetText() {
		
		UnityWebRequest request = UnityWebRequest.Get("http://api.openweathermap.org/data/2.5/weather?id=2172797&APPID=702367da6775090551215694c7a7fea9");
		yield return request.SendWebRequest();
		//yield return request.Send ();

		if(request.isNetworkError || request.isHttpError) {
			Debug.Log(request.error);
		}
		else {
			// Show results as text
			//Debug.Log(request.downloadHandler.text);
			//var resultTXT = request.downloadHandler.text;
			var result = JSON.Parse (request.downloadHandler.text);

			location = result ["name"].Value;
			weather = result ["weather"] [0] ["main"].Value;
			Debug.Log ("weather in " + location + " is " + weather);
		}
	}


	void Update(){

		if (!bHasWeather) {
			if (weather == "Clouds") {
				myWeather = Instantiate<GameObject> (weatherIcons[0]);
				Debug.Log("yay clouds!");
				bHasWeather = true;

			} else if (weather == "Sunny") {
				myWeather = Instantiate<GameObject>(weatherIcons[1]);
				Debug.Log("yay sun!");
				bHasWeather = true;

			}

		}



	}
}