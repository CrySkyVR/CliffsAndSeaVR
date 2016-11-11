using UnityEngine;
using System.Collections;

public class Facing : MonoBehaviour {

	public Transform objetivo;
	public Vector3 direccionInicial;



	
	// Update is called once per frame
	void Update () {

		transform.LookAt (objetivo,direccionInicial);
	
	}
}
