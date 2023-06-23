using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI text;
    public static int score;

    private void Start()
    {
        score = JsonController.save.money;
        text.text = "MoneyIsMoney: " + (int)score;
    }
    public void ScorePlus(int value)
    {
        score += value;
        text.text = "MoneyIsMoney: " + (int)score;
    }
}
