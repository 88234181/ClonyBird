using UnityEngine;
using System.Collections;

public class SkyMover : MonoBehaviour {

    float speed = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
	}
}
