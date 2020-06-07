using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Upgrade : MonoBehaviour
{
    public string upgradeName;
    public int upgradeLevel = 1;
    public int moneyNeededToActivate;
    public int price;
    public bool hasBeenBought;
    public bool isActive;

    TextMeshProUGUI name;

    Image buttonImage;

    private void Start()
    {
        buttonImage = GetComponent<Image>();
        name = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (!hasBeenBought)
        {
            name.text = "Price: " + price.ToString();
            buttonImage.color = Color.red;
        }
        else
        {
            name.text = upgradeName + "\nLevel up: " + price.ToString();
            buttonImage.color = Color.green;
        }
    }

    public void BuyUpgrade()
    {
        if (!hasBeenBought && GameManager.money >= price)
        {
            GameManager.money -= price;
            hasBeenBought = true;
            price += price / 2;
        }
        else if(hasBeenBought && GameManager.money >= price)
        {
            GameManager.money -= price;
            upgradeLevel++;
            price += price / 2;
        }
    }

}
