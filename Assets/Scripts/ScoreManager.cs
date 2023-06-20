using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI text;
    public static float score;


    public void ScorePlus(float value)
    {
        score += value;
        text.text = "MoneyIsMoney: " + (int)score;
    }
}
