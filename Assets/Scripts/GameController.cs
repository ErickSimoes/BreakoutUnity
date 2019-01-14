using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Transform brick;
    
    void Start() {
        CreateBricks();
    }

    void Update() {
        
    }

    /// <summary>
    /// Finish the game
    /// </summary>
    public static void GameOver() {
        Debug.Log("Game Over");
    }

    public void CreateBricks() {
        for (float x = -9; x < 9; x = x + 1.196f) {
            Instantiate(brick, new Vector3(x, 2, 0), Quaternion.identity);
        }
    }

}
