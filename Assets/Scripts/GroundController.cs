using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{
    void Start() {
        
    }

    void Update() {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        GameController.GameOver(false);
    }
}
