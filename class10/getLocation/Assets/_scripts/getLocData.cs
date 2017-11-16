using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getLocData : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//string locText = getLocation.Instance.lat.ToString() + "\n"+ getLocation.Instance.lon.ToString();
		//this.GetComponent<TextMesh> ().text = locText;
		this.GetComponent<TextMesh>().text = getLocation.Instance.lat.ToString () + "\n" + getLocation.Instance.lon.ToString () + "\n";

	}

	void Update(){
		this.GetComponent<TextMesh>().text = getLocation.Instance.lat.ToString () + "\n" + getLocation.Instance.lon.ToString () + "\n";


	}
}
