using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCube : MonoBehaviour {
    float sumtime = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        sumtime += Time.deltaTime;
        transform.position= new Vector3( Mathf.PingPong(sumtime*1, 3),1,0);
	}
}
