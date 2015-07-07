using UnityEngine;
using System.Collections;

public class BalanceController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    IEnumerator ChangeScene(int sec)
    {
        yield return new WaitForSeconds(sec);
        Application.LoadLevel("Menu");
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag.Equals("Ground"))
        {
            StartCoroutine(ChangeScene(3));
        }
    }

	// Update is called once per frame
	void Update () {
	
	}
}
