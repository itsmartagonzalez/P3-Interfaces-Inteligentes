using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public Transform target;
    // Start is called before the first frame update
    void Start() {
        ObjectA.eventDistanceA += Look;
        ObjectA.eventResetA += ResetRotation;
        target = GameObject.Find("ObjectB").GetComponent<Transform>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.A)) {
            transform.position += Vector3.left;
        } else if (Input.GetKeyDown(KeyCode.D)) {
            transform.position += Vector3.right;
        } else if (Input.GetKeyDown(KeyCode.W)) {
            transform.position += Vector3.forward;
        } else if (Input.GetKeyDown(KeyCode.S)) {
            transform.position += Vector3.back;
        }
    }

    void Look() {
        Vector3 oldPosition = transform.position;
        transform.LookAt(target);
        Debug.DrawRay(transform.position, transform.forward * 5, Color.red, 0.1f, true);
    }
    void ResetRotation() {
        transform.rotation = Quaternion.Euler(0, -180, 0);
        Debug.DrawRay(transform.position, transform.forward * 5, Color.red, 0.1f, true);
    }
}
