using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int gold = 0;

    public TMP_Text goldAmmount;
    public Player player;
    public Enemy enemy;
    public GameObject game;
    public GameObject pauseMenu;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        goldAmmount.text = "Gold:" + gold;

        if(enemy.gameObject == null)
        {
            Instantiate(enemy.gameObject, game.transform);
        }
        if(Input.GetKeyDown(KeyCode.Escape))
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

        if (Input.GetMouseButtonDown(0))
        {
            if (enemy.isAlive)
            {
                StartCoroutine(enemy.TakeDamage(player.damage));
                gold++;
            }
        }
    }

    IEnumerator SpawnEnemy()
    {
        yield return new WaitForSeconds(0.3f);
        Instantiate(enemy, game.transform);
    }
}
