using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera360 : MonoBehaviour {

    private float turnSpeed = 3.0f;      // Speed of camera turning when mouse moves in along an axis
    

    private Vector3 mouseOrigin;    // Position of cursor when mouse dragging starts
    private bool isRotating;    // Is the camera being rotated?

                                // Use this for initialization
    void Start () {
        isRotating = true;
        mouseOrigin = new Vector3(Screen.width/2, 0f, 0f);//Input.mousePosition;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.mousePosition.x > Screen.width /3 && Input.mousePosition.x < (Screen.width / 3) * 2) {
            mouseOrigin.x = Input.mousePosition.x;
        }
        if (Input.mousePosition.y > Screen.height / 3 && Input.mousePosition.y < (Screen.height / 3) * 2) {
            mouseOrigin.y = Input.mousePosition.y;
        }

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);

        if (isRotating) {
            transform.RotateAround(transform.position, transform.right, -pos.y * turnSpeed);
            transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
                      
        }
    }
}
