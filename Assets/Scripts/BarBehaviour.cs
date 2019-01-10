using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarBehaviour : MonoBehaviour {

    public float speed = 20f;

    void Start() {
        
    }

    void FixedUpdate() {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * Input.GetAxisRaw("Horizontal") * speed;
    }
}
