using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour {

    public float turnSpeed = 4.0f;      // Speed of camera turning when mouse moves in along an axis
    public int maxAngle;

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
        Debug.Log(transform.eulerAngles.y);

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - mouseOrigin);
        Debug.Log(pos.x);

        if (isRotating) {
            bool rotateRight = false;
            bool rotateLeft = false;
            if (pos.x >= 0) {
                rotateRight = true;
                rotateLeft = false;
            } else {
                rotateLeft = true;
                rotateRight = false;
            }
            if (maxAngle > 0) {
                if (rotateRight) {
                    if (transform.eulerAngles.y <= maxAngle || transform.eulerAngles.y >= 360 - maxAngle - 10) {
                        transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
                    }
                    if (transform.eulerAngles.y > maxAngle && transform.eulerAngles.y < maxAngle + 10) {
                        Quaternion rot = new Quaternion();
                        rot.eulerAngles = new Vector3(0, maxAngle, 0);
                        transform.rotation = rot;
                    }
                }
                if (rotateLeft) {
                    if (transform.eulerAngles.y <= maxAngle + 10 || transform.eulerAngles.y >= 360 - maxAngle) {
                        transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
                    }
                    if (transform.eulerAngles.y < 360 - maxAngle && transform.eulerAngles.y > 360 - maxAngle - 10) {
                        Quaternion rot = new Quaternion();
                        rot.eulerAngles = new Vector3(0, 360 - maxAngle, 0);
                        transform.rotation = rot;
                    }
                }
            }else {
                transform.RotateAround(transform.position, Vector3.up, pos.x * turnSpeed);
            }           
        }
    }
}
