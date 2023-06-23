using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class PanelController : MonoBehaviour
{
    public GameObject panel;
    private bool isOn = false;

    public TextMeshProUGUI SellGreenText;
    public static float soldGreen;
    public TextMeshProUGUI GoldG;
    public static float goldG;

    public TextMeshProUGUI SellYellowText;
    public static float soldYellow;
    public TextMeshProUGUI GoldY;
    public static float goldY;

    public TextMeshProUGUI SellPurpleText;
    public static float soldPurple;
    public TextMeshProUGUI GoldP;
    public static float goldP;
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
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
