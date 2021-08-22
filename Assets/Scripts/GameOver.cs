using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

   public void TryAgain(){
       Invoke("SceneLoader",1);
   }

   public void Exit(){
       Application.Quit();
   }

   public void PlayAgain(){
       Time.timeScale=1;
       SceneLoader();
   }

   


    void SceneLoader()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}
