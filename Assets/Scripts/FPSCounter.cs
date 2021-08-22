using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FPSCounter : MonoBehaviour
{
    float FPS;
    int avgFrameRate;
    [SerializeField]TextMeshProUGUI FPSText;
    void Update()
    {
        FPS=1/Time.unscaledDeltaTime;
        avgFrameRate=(int)FPS;
        FPSText.text=avgFrameRate.ToString();

        if(Input.GetKeyDown(KeyCode.F)){
            FPSText.enabled=!FPSText.enabled;
        }
    }
}
