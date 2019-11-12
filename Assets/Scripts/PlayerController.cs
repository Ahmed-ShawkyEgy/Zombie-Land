using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private GameObject axe, gun;
    [SerializeField]
    private ParticleSystem gunFire;
    private bool isHoldingAxe, isHoldingGun;

    private void Start()
    {
        isHoldingAxe = false;
        isHoldingGun = false;
        axe.SetActive(false);
        gun.SetActive(false);
    }

    public void HoldAxe()
    {
        gun.SetActive(false);
        axe.SetActive(true);
        isHoldingAxe = true;
    }

    public void HoldGun()
    {
        axe.SetActive(false);
        gun.SetActive(true);
        isHoldingGun = true;
    }

    public void PlayFire()
    {
        gunFire.Play();
    }
}
