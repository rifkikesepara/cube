using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
   [SerializeField]Canvas finishCanvas,scoreCanvas;

   private void Start() {
       finishCanvas.enabled=false;
   }

   private void OnTriggerEnter(Collider other) {
       finishCanvas.enabled=true;
       scoreCanvas.enabled=false;
       Time.timeScale=0;
       Cursor.lockState=CursorLockMode.None;
        Cursor.visible=true;
   }
}
