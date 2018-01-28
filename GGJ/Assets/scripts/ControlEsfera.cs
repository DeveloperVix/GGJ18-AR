using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEsfera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NewPosition(GameObject casilla){
		transform.position = new Vector3 (casilla.transform.position.x, casilla.transform.position.y, casilla.transform.position.z);
	}

	public void UpSelection()
	{
		Debug.Log ("Seleccion liberada");
	}
}
