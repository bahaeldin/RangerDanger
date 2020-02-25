﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameSettings
{
    //controlling oil
    public static float oilPerTorch = 20f;
    public static float oilDepleteRate = 5f;
    public static float startingOil = 100f;

    //camper
    public static float lerpSpeed = 0.02f; //between 0 and 1
    public static float stopDist = 2f;
    public static float detectDist = 3f;
}
