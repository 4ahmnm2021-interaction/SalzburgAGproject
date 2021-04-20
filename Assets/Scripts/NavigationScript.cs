using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationScript : MonoBehaviour
{
    public GameObject auswahlGroup;

    public GameObject informationGroup;

    public GameObject arScreen;

    public GameObject toggleMenu;

    public GameObject mapGroup;

    public GameObject homeScreen;

    public GameObject sidepanel;

    // Update is called once per frame
    private void Start()
    {
        homeScreen.SetActive(true);
    }

    public void Home()
    {
        homeScreen.SetActive(true);
    }

    public void Burger()
    {
        sidepanel.SetActive(true);
    }

    public void BurgerOff()
    {
        sidepanel.SetActive(false);
    }

    public void MenuInfo()
    {
        informationGroup.SetActive(true);
        homeScreen.SetActive(false);
    }

    public void MenuAuswahl()
    {
        auswahlGroup.SetActive(true);
        homeScreen.SetActive(false);
    }

    public void MenuAr()
    {
        arScreen.SetActive(true);
        homeScreen.SetActive(false);
    }

    public void MenuMap()
    {
        mapGroup.SetActive(true);
        homeScreen.SetActive(false);
    }

    public void ErsterSchein()
    {
        informationGroup.SetActive(true);
        auswahlGroup.SetActive(false);
    }

    public void Map()
    {
        mapGroup.SetActive(true);
        auswahlGroup.SetActive(false);
    }

    public void ArView()
    {
        arScreen.SetActive(true);
        toggleMenu.SetActive(true);
        informationGroup.SetActive(false);
    }

    public void SalzburgAGButtonInfo()
    {
        auswahlGroup.SetActive(true);
        informationGroup.SetActive(false);
    }

    public void SalzburgAGButtonAR()
    {
        informationGroup.SetActive(true);
        arScreen.SetActive(false);
        toggleMenu.SetActive(false);
    }
}
