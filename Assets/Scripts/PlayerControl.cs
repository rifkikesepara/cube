using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI cubeText;
    [SerializeField]float speed=5;
    [SerializeField]float xRange;
    [SerializeField]public GameObject trail,stickman;
    [SerializeField]Camera cam;
    [SerializeField]ParticleSystem scoreParticle;
    public int score=0;
    float maxFOV=100f;
    float minFov=80f;

    void Start()
    {
        Debug.Log("Score is: "+score);
        cubeText.text=score.ToString();
        
    }

    
    void Update()
    {
        float xThrow=Input.GetAxis("Horizontal");
        float newXpos= (xThrow*Time.deltaTime*speed)+transform.localPosition.x;
        float clampedXPos=Mathf.Clamp(newXpos,-xRange,xRange);
        transform.localPosition=new Vector3(clampedXPos,transform.localPosition.y,transform.localPosition.z);
        
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
        
    }


    public void Score(bool blabla){
        if(blabla){
            score++;
            scoreParticle.Play();
        }else{
            score--;
        }
        Debug.Log("Score is: "+score);
        cubeText.text=score.ToString();

    }

    public void GetCubes(Transform parented){
        Vector3 Xinc=new Vector3(0,1f,0);
        Instantiate(parented,new Vector3(transform.position.x,transform.position.y-score,transform.position.z),Quaternion.identity,stickman.transform);
        gameObject.transform.Translate(Xinc);
        trail.transform.Translate(0,0,1);
        
        
    }
    
    public void CameraFOV(bool condition){
        if(condition){
        cam.fieldOfView=Mathf.Lerp(cam.fieldOfView,maxFOV,0.2f);
        cam.transform.Translate(0,1,-1);
        }
        else{
            cam.fieldOfView=Mathf.Lerp(cam.fieldOfView,minFov,0.2f);
            cam.transform.Translate(0,-1,1);
        }
    }

    public void SetParrentNull(){
        gameObject.transform.SetParent(null);
    }

    

    
}
