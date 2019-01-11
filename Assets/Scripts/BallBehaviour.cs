using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour {

    public float speedX = 0.08f;
    public float speedY = 0.08f;

    void Start() {
        
    }

    void FixedUpdate() {
        transform.position = new Vector3(transform.position.x + speedX, transform.position.y + speedY);
    }

    private void OnCollisionEnter2D(Collision2D collision) {

        if (collision.gameObject.tag == "VerticalLimits") {
            speedX = -speedX;
        }

        if (collision.gameObject.tag == "HorizontalLimits") {
            speedY = -speedY;
        }

    }
}
