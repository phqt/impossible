using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Goal : MonoBehaviour
{
    public Transform Basketball;
    public TextMeshProUGUI score;

    int displayScore = 0;



    void OnTriggerEnter(Collider other)
    {
        displayScore++;

        score.text = displayScore.ToString();
    }

}
