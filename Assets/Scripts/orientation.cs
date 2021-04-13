using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orientation : MonoBehaviour
{
 public void Roatet()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Debug.Log("Worked");
    }
}
