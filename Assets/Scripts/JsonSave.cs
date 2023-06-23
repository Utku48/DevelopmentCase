using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JsonSave
{
    public float money;
    public float sellGemCountY;
    public float sellGemCountG;
    public float sellGemCountP;


    public JsonSave()
    {
        this.money = ScoreManager.score;
        this.sellGemCountY = PanelController.soldYellow;
        this.sellGemCountG = PanelController.soldGreen;
        this.sellGemCountP = PanelController.soldPurple;
    }


}
