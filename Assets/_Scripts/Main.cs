using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Main : MonoBehaviour {

    public string actualMaterial;
    public string actualPoligon;
    public int actualQuantity;
    public GameObject actualPuzzle;
    public GameObject[] shapes;
    public Texture[] textures;
    public float actualHigh;
    public float actualSize;
    public float totalQuantity = 0;
    
<<<<<<< HEAD

    /*
    public void InstatiateCostume(GameObject obj, Vector3 vector3, Texture3D texture, string tag)
    { 
        Instantiate(obj,vector3, this.transform.rotation);
        obj.tag = tag;
    }
    */
    public void SpawnObject()
    {
        Vector3 t = actualPuzzle.transform.FindChild("InstantiateSPoint").position;
        int g = actualQuantity;

=======
    public void SpawnObject()
    {
        Vector3 t = actualPuzzle.transform.FindChild("InstantiateSPoint").position;
        int g =actualQuantity;
>>>>>>> origin/master
            for (int i = 0; i < 3; i++)
            {
                if (actualPoligon.Equals("Cubo"))
                {
<<<<<<< HEAD
                    GameObject obj;

                    switch(actualMaterial)
                    {

                        case "Ferro":
                            obj = shapes[2];
                            break;
                        case "Madeira":
                            obj = shapes[1];
                            break;
                        case "Ouro":
                            obj = shapes[5];
                            break;
                        case "Poliestireno":
                            obj = shapes[4];
                            break;
                        case "Chumbo":
                            obj = shapes[7];
                            break;
                        case "Diamante":
                            obj = shapes[6];
                            break;
                        case "Mercurio":
                            obj = shapes[3];
                            break;
                        default:
                            obj = shapes[0];
                            break;
                    }
                    
=======
                    Debug.Log("oioio");
                    GameObject obj = shapes[0];
>>>>>>> origin/master
                    obj.SetActive(true);
                    obj.tag = actualMaterial;
                    obj.AddComponent<MassCalc>();
                    obj.GetComponent<Rigidbody>().useGravity = false;
                    obj.GetComponent<BoxCollider>().enabled = false;
                    obj.transform.localScale = new Vector3(actualSize, actualHigh, actualSize);
                    obj.transform.position = new Vector3(t.x, t.y, t.z - (actualSize * i));
                    Instantiate(obj);
                    g--;
                }
                if (g >= 0) break;
            }
    }

	void Start ()
    { this.actualMaterial = ""; this.actualPoligon = ""; }

	void FixedUpdate ()
    {
        //Debug.Log(this.actualPoligon);
	}
}
