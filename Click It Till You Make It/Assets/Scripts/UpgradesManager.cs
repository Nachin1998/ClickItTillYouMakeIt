using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;

public class UpgradesManager : MonoBehaviour
{
    public List<Upgrade> upgradeButtons = new List<Upgrade>();

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < upgradeButtons.Count; i++)
        {
            SetButtonActive(upgradeButtons[i], upgradeButtons[i].moneyNeededToActivate);
        }
    }

    public void BuyButton(Upgrade button)
    {
        if (!button.hasBeenBought)
        {
            GameManager.money -= button.price;
        }

    }
    void SetButtonActive(Upgrade button, int moneyNeededToActivate)
    {
        if (GameManager.money >= moneyNeededToActivate)
        {
            button.gameObject.SetActive(true);
        }
        else
        {
            button.gameObject.SetActive(false);
        }
    }
}
