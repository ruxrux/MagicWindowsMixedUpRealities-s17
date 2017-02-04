using UnityEngine;
using System.Collections;

public class highLight : MonoBehaviour {

	bool isHighlighted = false;
	Material originalMaterial;
	Material newMaterial;
	MeshRenderer meshRenderer;

	GameObject baseObject;
	string obj_name;

	// Use this for initialization
	void Start () {

		obj_name 			= this.gameObject.name;
		baseObject 			= GameObject.Find( obj_name );
		meshRenderer 		= baseObject.GetComponent<MeshRenderer>();
		originalMaterial 	= meshRenderer.material;

		Color newColor 		= new Color(255.0f,255.0f,0.0f, 0.5f);
		newMaterial  		= new Material(Shader.Find("Transparent/Parallax Specular"));
//		redMaterial  		= new Material(Shader.Find("Mobile/VertexLit"));
		newMaterial.color 	= newColor;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnPoke(){

		Debug.Log("poking  " + obj_name);
		isHighlighted = !isHighlighted;

		if( isHighlighted ){

			Highlight();

		}else{

			RemoveHighlight();
		}
	}

	void Highlight(){

		meshRenderer.material = newMaterial;
	}

	void RemoveHighlight(){

		meshRenderer.material = originalMaterial;
	}
}
