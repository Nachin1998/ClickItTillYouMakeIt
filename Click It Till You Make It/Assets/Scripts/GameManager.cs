using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int money = 0;

    public TMP_Text overallIncome;
    public GameObject game;
    public GameObject pauseMenu;

    public int click;
    public int clickUpgrades;

    void Start()
    {
        click = 1;
        clickUpgrades = 1;
    }

    // Update is called once per frame
    void Update()
    {
        overallIncome.text = "Money:" + money;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.activeSelf)
            {
                pauseMenu.SetActive(false);
            }
            else
            {
                pauseMenu.SetActive(true);
            }
        }

        

        click *= clickUpgrades;
    }
    
    public void Mine()
    {
        money += click;
    }
}
