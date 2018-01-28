using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {

    public string namePlayer;
    public GameObject senial;

    public int nomMovimientos = 1;

    public int mov_afinidad = 1;
    public int vel = 2;


	// Use this for initialization
	void Start ()
    {
        namePlayer = this.name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CartaMovimiento()
    {
        nomMovimientos += mov_afinidad;
    }

    public void CartaVelocidad()
    {
        nomMovimientos *= vel;
    }
}
