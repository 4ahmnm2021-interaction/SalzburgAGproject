using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameRateSript : MonoBehaviour
{
    //Locks framerate at 30 fps
    private void Awake()
    {
        Application.targetFrameRate = 30;
    }
}
