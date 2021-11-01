using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start() {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        float translation = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("Horizontal");

        //Vector3 dir = new Vector3(rotation, 0.0f, translation) * (speed * 10) * Time.fixedDeltaTime;
        //rigidBody.AddForce(dir);
        rigidBody.position += new Vector3(rotation, 0.0f, translation) * 10 * Time.fixedDeltaTime;
    }

    /*void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Cylinder") {
            Debug.Log("Puntuación del Jugador: " + (++puntuation));
            transform.localScale += new Vector3(1, 1, 1);
        } else if (collision.gameObject.tag == "A_Cylinder" && Input.GetKey(KeyCode.Space)) {
            Vector3 direction = new Vector3(collision.transform.position.x - rigidBody.position.x, 0, collision.transform.position.z - rigidBody.position.z);
            collision.transform.Translate(direction * 2f * Time.deltaTime);
        }
    }*/
}
