using UnityEngine;
using System.Collections;

public class Obstacle_spawner : MonoBehaviour {

    public GameObject  obstacle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKeyDown) {
            GameObject clone;
            clone = (GameObject)Instantiate(obstacle, new Vector3(Random.Range(-10.0f,10.0f), 0, 50), Quaternion.identity);
            clone.transform.parent = this.transform;
           
        }
	}
}
