using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour {
    
    private void OnTriggerEnter2D(Collider2D collision) {
        GameController.state = GameController.GameOverState.lose;
    }
}
