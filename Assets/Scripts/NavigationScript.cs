using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationScript : MonoBehaviour
{
    public GameObject auswahlGroup;

    public GameObject informationGroup;

    public GameObject arScreen;

    public GameObject toggleMenu;

    // Update is called once per frame
    private void Start()
    {
        auswahlGroup.SetActive(true);
    }

    public void ErsterSchein()
    {
        informationGroup.SetActive(true);
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
