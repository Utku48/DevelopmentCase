using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JsonSave
{
    public int money;
    public int sellGemCountY;
    public int sellGemCountG;
    public int sellGemCountP;
    public int GoldG;
    public int GoldY;
    public int GoldP;


    public JsonSave()
    {
        this.money = ScoreManager.score;
        this.sellGemCountY = PanelController.soldYellow;
        this.sellGemCountG = PanelController.soldGreen;
        this.sellGemCountP = PanelController.soldPurple;
        this.GoldG = PanelController.goldG;
        this.GoldY = PanelController.goldY;
        this.GoldP = PanelController.goldP;

    }


}
