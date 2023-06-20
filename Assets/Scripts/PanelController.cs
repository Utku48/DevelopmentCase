using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PanelController : MonoBehaviour
{
    public GameObject panel;
    private bool isOn = false;

    public TextMeshProUGUI SellGreenText;
    public static float sellGreen;
    public TextMeshProUGUI GoldG;
    public static float goldG;

    public TextMeshProUGUI SellYellowText;
    public static float sellYellow;
    public TextMeshProUGUI GoldY;
    public static float goldY;

    public TextMeshProUGUI SellPurpleText;
    public static float sellPurple;
    public TextMeshProUGUI GoldP;
    public static float goldP;
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        SellGreenText.text = "Satılan Adet: " + sellGreen;
        GoldG.text = "Gold: " + goldG;
        SellYellowText.text = "Satılan Adet: " + sellYellow;
        GoldY.text = "Gold: " + goldY;
        SellPurpleText.text = "Satılan Adet: " + sellPurple;
        GoldP.text = "Gold: " + goldP;
    }

    public void On_Click()
    {
        isOn = !isOn;
        panel.SetActive(isOn);


    }


}
