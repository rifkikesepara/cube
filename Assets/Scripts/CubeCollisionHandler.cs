using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionHandler : MonoBehaviour
{
    PlayerControl playerControl;
    [SerializeField]GameObject instatiatecube;
    AudioHandler audioHandler;
    

    void Start() {
        playerControl=FindObjectOfType<PlayerControl>();
        audioHandler=FindObjectOfType<AudioHandler>();
    }

    void OnTriggerEnter(Collider other) {
        
        if(other.transform.tag=="Hitter"||other.transform.tag=="LastCube"){
            playerControl.Score(true);
            playerControl.CameraFOV(true);
            audioHandler.boxcollectSound();
            playerControl.GetCubes(instatiatecube.transform);
            Destroy(gameObject);
        }
    }
}
