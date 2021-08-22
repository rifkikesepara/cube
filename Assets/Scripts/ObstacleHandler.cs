using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHandler : MonoBehaviour
{
    PlayerControl playerControl;
    Rigidbody rb;
    GameObject kutu;
    [SerializeField]Canvas scoreCanvas,deathCanvas;
    

    void Start() {
        playerControl=FindObjectOfType<PlayerControl>();
        deathCanvas.enabled=false;
        scoreCanvas.enabled=true;
    }

    void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag=="Hitter"){
            other.gameObject.transform.SetParent(null);
            other.gameObject.tag="Hit";
            playerControl.CameraFOV(false);
            //Destroy(other.gameObject);
            playerControl.Score(false);
            kutu=other.gameObject;
            playerControl.trail.transform.Translate(0,0,-1.05f);
            Destroy(kutu,1);
        }

        if(other.gameObject.tag=="LastCube")
        {
            playerControl.SetParrentNull();
            Debug.Log("çarptı");
            scoreCanvas.enabled=false;
            Cursor.lockState=CursorLockMode.None;
            Cursor.visible=true;
            deathCanvas.enabled=true;
            //Invoke("SceneLoader",1);
        }
    }

   

}
