using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour {

    public GameObject[] players;    //Para saber quien esta jugando

    [Header("Botones")]
    public GameObject btnInicio;


    int jugadorPasado;
    int jugadorEnTurno;

    // Use this for initialization
    void Start () {
         jugadorPasado = 0;    //necesito asignarle el jugador que comenzo aleatoriamente
    }
	

    public void AcabaTurno()    //Para el boton de "siguiente turno"
    {
        jugadorEnTurno = jugadorPasado + 1;

        if (jugadorEnTurno > players.Length - 1)
        {
            jugadorEnTurno = 0;
        }

        for (int i = 0; i < players.Length; i++)
        {
            players[jugadorPasado].GetComponent<JugadorTurno>().turno = false;
        }

        players[jugadorPasado].GetComponent<JugadorTurno>().turno = true;
    }
}
