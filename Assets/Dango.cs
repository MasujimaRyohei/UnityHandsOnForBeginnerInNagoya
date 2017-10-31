using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dango : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(GameObject.FindWithTag("Player").transform);

	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            MasujimaRyohei.AudioManager.PlaySE("Decision");
        }
    }
}
