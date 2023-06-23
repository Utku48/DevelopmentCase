using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PanelController : MonoBehaviour
{
    public GameObject panel;
    private bool isOn = false;

    public TextMeshProUGUI SellGreenText;
    public static int soldGreen;
    public TextMeshProUGUI GoldG;
    public static int goldG;

    public TextMeshProUGUI SellYellowText;
    public static int soldYellow;
    public TextMeshProUGUI GoldY;
    public static int goldY;

    public TextMeshProUGUI SellPurpleText;
    public static int soldPurple;
    public TextMeshProUGUI GoldP;
    public static int goldP;


    void Start()
    {
        soldGreen = JsonController.save.sellGemCountG;
        soldYellow = JsonController.save.sellGemCountY;
        soldPurple = JsonController.save.sellGemCountP;

        goldP = JsonController.save.GoldP;
        goldY = JsonController.save.GoldY;
        goldG = JsonController.save.GoldG;



        panel.SetActive(false);
    }


    void Update()
    {
        SellGreenText.text = "Satılan Adet: " + soldGreen;
        GoldG.text = "Gold: " + goldG;
        SellYellowText.text = "Satılan Adet: " + soldYellow;
        GoldY.text = "Gold: " + goldY;
        SellPurpleText.text = "Satılan Adet: " + soldPurple;
        GoldP.text = "Gold: " + goldP;
    }

    public void On_Click()
    {
        isOn = !isOn;
        panel.SetActive(isOn);
    }


}
