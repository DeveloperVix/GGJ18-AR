using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GM : MonoBehaviour {

    public GameObject[] players;    //Para saber quien esta jugando


    int jugadorPasado;
    int jugadorEnTurno;

    //0-7   anillo1
    //8-15  anillo2
    //16-23 anillo3
    //24-31 anillo4
    //32-39 anillo5
    //40-47 anillo6
    //48-55 anillo7

    public List<GameObject> anillos = new List<GameObject>();

    public int numAnillo = 0;
    public int posicionSeñal = 0; //numero 0-55


    // Use this for initialization
    void Start()
    {
        jugadorPasado = 0;    //necesito asignarle el jugador que comenzo aleatoriamente

        Debug.Log(anillos.Count);
    }

    public void NuevaPosicion(string nameCasilla) //Se manda llamar cuando la señal se mueve
    {

        for (int i = 0; i < anillos.Count; i++)     
        {
            if (anillos[i].gameObject.name == nameCasilla)
            {
                posicionSeñal = i;                          //Obtenemos la posicion de la señal

                if (i >= 0 && i <= 7)
                {
                    numAnillo = 1;              //Obtenemos el anillo
                }
                else if (i >= 8 && i <= 15)
                {
                    numAnillo = 2;
                }
                else if (i >= 16 && i <= 23)
                {
                    numAnillo = 3;
                }
                else if (i >= 24 && i <= 31)
                {
                    numAnillo = 4;
                }
                else if (i >= 32 && i <= 39)
                {
                    numAnillo = 5;
                }
                else if (i >= 40 && i <= 47)
                {
                    numAnillo = 6;
                }
                else if (i >= 48 && i <= 55)
                {
                    numAnillo = 7;
                }

                i = 56;                                     //Rompemos el ciclo
            }
        }

        Debug.Log("Posicion Señal: " + posicionSeñal);
        Debug.Log("En el anillo: " + numAnillo);

        for (int i = 0; i < anillos.Count; i++)     //Desactivamos las casillas
        {
           // anillos[i].SetActive(false);
        }

    }

    public void DesactivaAnillos(GameObject[] casillasAnillo)
    {
        
    }

    

    public void CambiaCasilla()
    {

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
