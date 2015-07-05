using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

	void Start () 
    {
	
	}

    void OnMouseDown()
    {
        this.rigidbody.isKinematic = true;

        this.transform.position = Camera.main.ScreenToViewportPoint(Input.mousePosition);
    }
	
	void FixedUpdate () 
    {
	    
	}
}
