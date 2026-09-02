using UnityEngine;
using System.Collections;

public class RotateAround : MonoBehaviour {

	public Transform centro_de_rotacao; // the object to rotate around
	public int speed; // the speed of rotation
	
	void Start() {
		if (centro_de_rotacao == null) 
		{
			centro_de_rotacao = this.gameObject.transform;
			Debug.Log ("RotateAround centro_de_rotacao not specified. Defaulting to parent GameObject");
		}
	}

	// Update is called once per frame
	void Update () {
		// RotateAround takes three arguments, first is the Vector to rotate around
		// second is a vector that axis to rotate around
		// third is the degrees to rotate, in this case the speed per second
		transform.RotateAround(centro_de_rotacao.transform.position,
		                       centro_de_rotacao.transform.up,
							   speed * Time.deltaTime);
	}
}
