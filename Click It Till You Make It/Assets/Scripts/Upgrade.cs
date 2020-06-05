using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upgrade : MonoBehaviour
{
    public GameManager gManager;
    public int moneyNeededToActivate;
    public int price;
    public bool hasBeenBought;
    public bool isActive;

    public void EnchanceClickBy1()
    {
        gManager.click++;
    }
}
