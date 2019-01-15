using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public Transform brick;

    private static int points;

    public static int Points {
        get => points;
        set {
            if (points <= 0) {
                GameOver(true);
            }
            points = value;
        }
    }

    void Start() {
        CreateBricks();
    }
    
    /// <summary>
    /// Finish the game
    /// True if win or false if lose.
    /// </summary>
    public static void GameOver(bool win) {
        if (win) {
            Debug.Log("Win!");
        } else {
            Debug.Log("Game Over");
        }
    }

    public void CreateBricks() {
        for (float y = 2; y > 0; y = y - 1.179f) {
            for (float x = -9; x < 9; x = x + 1.196f) {
                Instantiate(brick, new Vector3(x, y, 0), Quaternion.identity);
                points++;
            }
        }
    }




}
