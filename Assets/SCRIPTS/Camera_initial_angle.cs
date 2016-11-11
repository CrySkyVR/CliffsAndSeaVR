using UnityEngine;
using System.Collections;

public class Camera_initial_angle : MonoBehaviour {


	//public Transform angulo;
	public Vector3 direccionInicial;

	// Use this for initialization
	void Start () {
		//angulo=GetComponent<Transform>()=new V
		transform.LookAt (direccionInicial);
	
	}
	

}
