using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectB : MonoBehaviour {
    public delegate void delegateB();
    public static event delegateB eventCollisionB;
    private Text displayText;
    private int forceA;
    void Start() {
        forceA = 0;
        displayText = GameObject.Find("Text").GetComponent<Text>();
        ObjectA.eventCollisionA += incrementForce;
        ObjectA.eventDistanceA += changeColor;
    }

    void  OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "Player") {
            eventCollisionB();
        }
    }

    void incrementForce() {
        forceA++;
        displayText.text = "\nSoy el objeto B.\nEl jugador colisionó con el objeto A y por eso su fuerza aumenta.\n" +
        "Fuerza del objeto A:" + forceA;
    }

    void changeColor() {
        Color newColor = new Color(Random.value, Random.value, Random.value, Time.deltaTime);
        GetComponent<Renderer>().material.color = newColor;
    }
}
