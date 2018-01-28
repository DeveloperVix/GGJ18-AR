using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEsfera : MonoBehaviour {

    public GM statusCasillas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void NewPosition(GameObject casilla)
    {
        Debug.Log("Posicion: " + casilla.name);
		transform.position = new Vector3 (casilla.transform.position.x, casilla.transform.position.y, casilla.transform.position.z);

        statusCasillas.NuevaPosicion(casilla.name);
	}

	public void UpSelection()
	{
		Debug.Log ("Seleccion liberada");
	}
}
