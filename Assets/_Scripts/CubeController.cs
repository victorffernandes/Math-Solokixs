using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour {

    public Vector3 StartPosition;
    public bool isPlayable = false;
    


	void Start ()
    { StartPosition = transform.localPosition;  }

    void OnMouseDown()
    {
        if (isPlayable && Main.deleteMode)
        {
            //GameObject.FindGameObjectWithTag("Main").GetComponent<Main>().totalQuantity--;
            Destroy(gameObject);
        }
    }

	void FixedUpdate () 
    {
	    
	}
}
