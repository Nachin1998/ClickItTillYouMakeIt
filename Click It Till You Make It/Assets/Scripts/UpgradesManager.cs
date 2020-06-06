using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{
    public GameManager gManager;
    public Transform upgradesMenu;
    public TMP_Text moneyPerClick;

    public List<Upgrade> upgradeButtons = new List<Upgrade>();

    float timer = 0;
    float maxTimer = 5;
    public int miners = 0;
    int minersMoney = 1;

    private void Start()
    {
        /*for (int i = 0; i < upgradeButtons.Count; i++)
        {
            Instantiate(upgradeButtons[i], upgradesMenu);
        }*/
    }
    void Update()
    {
        moneyPerClick.text = "Money per click: " + gManager.click;

        for (int i = 0; i < upgradeButtons.Count; i++)
        {
            SetButtonActive(upgradeButtons[i], upgradeButtons[i].moneyNeededToActivate);
        }


        //Upgrade 2
        if(miners > 0)
        {
            if (timer < maxTimer)
            {
                timer += Time.deltaTime;
            }
            else
            {
                GameManager.money += minersMoney;
                timer = 0;
            }
        }
    }

    void SetButtonActive(Upgrade button, int moneyNeededToActivate)
    {
        if (!button.hasBeenBought && !button.isActive)
        {
            if (GameManager.money >= moneyNeededToActivate)
            {
                button.isActive = true;
                button.gameObject.SetActive(true);
            }
            else
            {
                button.gameObject.SetActive(false);
            }
        }
        else
        {
            button.isActive = true;
            button.gameObject.SetActive(true);
        }
    }

    public void EnchanceClickBy1(Upgrade button)
    {
        if (button.hasBeenBought)
        {
            gManager.click++;
        }
    }

    public void HireMiners(Upgrade button)
    {
        if (button.hasBeenBought)
        {
            miners++;
            maxTimer /= miners;
        }
    }
}