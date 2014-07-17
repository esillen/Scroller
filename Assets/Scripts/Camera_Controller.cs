using UnityEngine;
using System.Collections;

public class Camera_Controller : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
	void Update () {

        float horizontalMovement = Input.GetAxis("Horizontal");
        transform.position = new Vector3(transform.position.x+horizontalMovement*speed*Time.deltaTime,transform.position.y,transform.position.z);

	}
}
