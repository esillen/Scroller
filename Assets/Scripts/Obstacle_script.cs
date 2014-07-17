using UnityEngine;
using System.Collections;

public class Obstacle_script : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 v = transform.position;
        v.z = transform.position.z - speed*Time.deltaTime;
        transform.position = v;
        if (transform.position.z <= -10) {
            Destroy(this.gameObject);
        }
	}
}
