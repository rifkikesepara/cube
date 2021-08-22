using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    Score scorehandler;
    AudioHandler audioHandler;

    private void Start() {
        scorehandler=FindObjectOfType<Score>();
        audioHandler=FindObjectOfType<AudioHandler>();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Hitter"||other.gameObject.tag=="LastCube"){
            audioHandler.diamondcollectSound();
            scorehandler.SetScore();
            Destroy(gameObject);
        }
    }
}
