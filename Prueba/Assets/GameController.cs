﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public delegate void metodoDelegado();
	public static metodoDelegado Evento;
	
	void OnCollisionEnter(Collision other) {
			Evento();
	}
}
