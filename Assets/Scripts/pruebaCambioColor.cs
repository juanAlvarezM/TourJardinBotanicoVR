using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaCambioColor : MonoBehaviour {
    public GameObject flechaGamObject;
    public Color color;
	// Use this for initialization
	void Start () {
      //  flechaGamObject.GetComponentInChildren<Renderer>().material.color = color;
        Debug.Log(flechaGamObject.GetComponent<Transform>().childCount);
        for (int i = 0; i< flechaGamObject.GetComponent<Transform>().childCount; i++)
        {
            flechaGamObject.GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = color;
        }
        //flecha.GetComponent<Renderer>().material.color = color;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
