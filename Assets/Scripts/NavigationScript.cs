﻿using System.Collections;
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
    public GameObject SearchBars;
    public GameObject Header;

    // Update is called once per frame
    private void Deactivate()
    {
        sidepanel.SetActive(false);
        mapGroup.SetActive(false);
        toggleMenu.SetActive(false);
        arScreen.SetActive(false);
        informationGroup.SetActive(false);
        auswahlGroup.SetActive(false);
    }
    private void Start()
    {
        homeScreen.SetActive(true);
        SearchBars.SetActive(true);
        Deactivate();
    }

    public void Home()
    {
        homeScreen.SetActive(true);
        SearchBars.SetActive(true);
        Deactivate();
        Header.SetActive(true);

    }

    public void Burger()
    {
        if (sidepanel.activeSelf)
        {
        sidepanel.SetActive(false);
        }
        else
        {
            sidepanel.SetActive(true);
        }
        
    }

    private void Update()
    {
        if (arScreen.activeSelf)
        {
            toggleMenu.SetActive(true);
        }
        else
        {
            toggleMenu.SetActive(false);
        }
    }

    public void MenuInfo()
    {
        informationGroup.SetActive(true);
        SearchBars.SetActive(false);
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
        SearchBars.SetActive(false);
        
    }

    public void MenuMap()
    {
        mapGroup.SetActive(true);
        homeScreen.SetActive(false);
        SearchBars.SetActive(false);
        Header.SetActive(false);
    }

    public void ErsterSchein()
    {
        informationGroup.SetActive(true);
        auswahlGroup.SetActive(false);
        SearchBars.SetActive(false);
    }

    public void Map()
    {
        mapGroup.SetActive(true);
        auswahlGroup.SetActive(false);
        SearchBars.SetActive(false);
        Header.SetActive(false);
    }

    public void ArView()
    {
        arScreen.SetActive(true);
        toggleMenu.SetActive(true);
        informationGroup.SetActive(false);
        Header.SetActive(true);
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
