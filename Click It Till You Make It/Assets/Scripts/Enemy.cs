using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int enemyLevel;
    public float health;
    public bool isAlive = true;
    private Color enemyColor;

    void Start()
    {
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(health > 0)
        {
            isAlive = true;
        }
        else if (health <= 0)
        {
            isAlive = false;
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public IEnumerator TakeDamage(float damageToTake)
    {
        //enemyColor = Color.red;
        GetComponent<Image>().color = Color.red;
        health -= damageToTake;
        yield return new WaitForSeconds(0.1f);

        if (isAlive)
        {
            //enemyColor = Color.white;
            GetComponent<Image>().color = Color.white;
        }
    }

  
}
