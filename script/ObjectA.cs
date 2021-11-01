using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectA : MonoBehaviour {
    public delegate void delegateA();
    public static event delegateA eventCollisionA;
    public static event delegateA eventDistanceA;
    public static event delegateA eventResetA;

    private Text displayText;
    GameObject player;

    void Start() {
        displayText = GameObject.Find("Text").GetComponent<Text>();
        ObjectB.eventCollisionB += printOnScreen;

        player = GameObject.Find("Player");
    }

    void Update() {
        float distanceWithPlayer = Vector3.Distance(player.GetComponent<Rigidbody>().position, transform.position);
        if (distanceWithPlayer < 2f) {
            eventDistanceA();
        } else {
            eventResetA();
        }
    }

    void  OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Player") {
            eventCollisionA();
        }
    }

    void printOnScreen() {
        displayText.text = "\nSoy el objeto A.\nEl jugador colisionó con el objeto B.";
    }
}
