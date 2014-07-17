using UnityEngine;
using System.Collections;

public class Obstacle_spawner : MonoBehaviour {

    public GameObject  obstacle;
    public float delay;
    private float lastTime;
    public bool spawning;

	// Use this for initialization
	void Start () {

	lastTime = Time.time;
    spawning = true;
	}
	
	// Update is called once per frame
	void Update () {
            if (Time.time >= lastTime+delay && spawning){
                lastTime = Time.time;
            GameObject clone;
            clone = (GameObject)Instantiate(obstacle, new Vector3(Random.Range(-10.0f,10.0f), 0, 100), Quaternion.identity);
            clone.transform.parent = this.transform;
            Obstacle_script otherScript = clone.GetComponent<Obstacle_script>();
            otherScript.os = this;
        }
    }
}
