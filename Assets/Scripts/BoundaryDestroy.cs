using System.Collections;
using UnityEngine;

public class BoundaryDestroy : MonoBehaviour {

	void OnTriggerExit(Collider other){

		Destroy (other.gameObject);

	}

}
