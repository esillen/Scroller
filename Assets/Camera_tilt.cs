using UnityEngine;
using System.Collections;

public class Camera_tilt : MonoBehaviour {

    public GameObject player;
    private float lastx;

    void Start() {
        transform.localEulerAngles = new Vector3(0, 0, 180);
    }

	// Update is called once per frame
	void Update () {

        float currentx = player.gameObject.transform.position.x;
        float velocity = -(currentx - lastx)/Time.deltaTime;
        lastx = currentx;
        float corrector = 0.005f;
        float angle = 180 + velocity * 30 * corrector;

        Debug.Log(angle);


        transform.localEulerAngles = Vector3.Lerp(new Vector3(0, 0, transform.localEulerAngles.z), new Vector3(0, 0, angle), 0.3f);


    }
}
