using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBehaviour : MonoBehaviour {

    private AudioSource source;

    private void Awake() {
        source = GetComponent<AudioSource>();
    }

    void Update() {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        source.Play();
        Destroy(gameObject, 0.044f);
    }
}
