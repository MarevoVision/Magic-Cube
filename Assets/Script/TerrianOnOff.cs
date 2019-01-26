using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrianOnOff : MonoBehaviour {

    public GameObject roomBox;
    public GameObject terrian;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(roomBox.GetComponent<MeshRenderer>().enabled == true){
            terrian.SetActive(true);
        }else{
            terrian.SetActive(false);
        }
	}
}
