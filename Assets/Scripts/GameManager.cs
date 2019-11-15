using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public GameObject weponChoice, helpGunChoice, helpAxeChoice, die, gameOver;
    public PlayerController player;    


    public void showWeponChoice()
    {
        weponChoice.SetActive(true);
    }

    public void closeWeponChoice()
    {
        weponChoice.SetActive(false);
    }

    public void showHelpChoice()
    {
        helpGunChoice.SetActive(true);
    }

    public void showHelpChoiceWithAxe()
    {
        helpAxeChoice.SetActive(true);
    }

    public void closeHelpChoice()
    {
        helpGunChoice.SetActive(false);
    }

    public void closeHelpAxeChoice()
    {
        helpAxeChoice.SetActive(false);
    }

    public void showGameOver()
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);
    }

    public void showDie()
    {
        Time.timeScale = 0;
        die.SetActive(true);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
