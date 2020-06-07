using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int money = 0;

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