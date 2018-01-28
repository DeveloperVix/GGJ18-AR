using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour {

    public GameObject[] players;

    public int tiempoTurno = 15;


    [Header("UI")]
    public Text tiempoTurnoTxt;

    [Header("Botones")]
    public GameObject btnInicio;


    public void IniciaJuego()
    {

    }

    IEnumerator TimeGame()
    {
        while (tiempoTurno > 0)
        {
            yield return new WaitForSeconds(1f);
            tiempoTurno--;
        }
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
