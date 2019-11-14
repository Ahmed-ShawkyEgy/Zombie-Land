using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public GameObject weponChoice, helpGunChoice;
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

    public void closeHelpChoice()
    {
        helpGunChoice.SetActive(false);
    }

}
