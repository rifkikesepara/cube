using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    int diamondscore=0;
    [SerializeField]TextMeshProUGUI diamondtext;

    void Start() {
        diamondtext.text=diamondscore.ToString();
    }

    public void SetScore()
    {
        diamondscore++;
        diamondtext.text=diamondscore.ToString();
    }
}
