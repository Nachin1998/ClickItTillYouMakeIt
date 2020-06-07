using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsManager : MonoBehaviour
{
    public GameManager gManager;
    public UpgradesManager uManager;

    public TMP_Text overallIncome;

    public TMP_Text moneyPerClick;
    public TMP_Text miners;

    
    // Update is called once per frame
    void Update()
    {
        overallIncome.text = "Money: " + GameManager.money;

        moneyPerClick.text = "Money per click: " + gManager.click;
        miners.text = "Miners: " + uManager.miners;
    }
}
