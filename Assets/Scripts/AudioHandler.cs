using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    AudioSource aS;
    [SerializeField]AudioClip collectBox,collectDiamond;

    void Start() {
        aS=gameObject.GetComponent<AudioSource>();  
    }

    public void boxcollectSound(){
        aS.PlayOneShot(collectBox);
    }

    public void diamondcollectSound()
    {
        aS.PlayOneShot(collectDiamond);
    }
}
