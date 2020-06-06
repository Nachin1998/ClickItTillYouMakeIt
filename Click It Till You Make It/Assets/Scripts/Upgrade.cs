using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour
{
    public int moneyNeededToActivate;
    public int price;
    public bool hasBeenBought;
    public bool isActive;

    Image buttonImage;

    private void Start()
    {
        buttonImage = GetComponent<Image>();
    }

    private void Update()
    {
        if (!hasBeenBought)
        {
            buttonImage.color = Color.red;
        }
        else
        {
            buttonImage.color = Color.green;
        }
    }

    public void BuyUpgrade()
    {
        if (!hasBeenBought && GameManager.money >= price)
        {
            GameManager.money -= price;
            //isActive = true;
            hasBeenBought = true;
        }
    }

}
