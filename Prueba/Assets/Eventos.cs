using UnityEngine;
using System.Collections;

public class Eventos : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameController.Evento += MetodoEjecutar;
	}

	void MetodoEjecutar(){
		GetComponent<Renderer>().material.color = Random.ColorHSV();
	}
}
