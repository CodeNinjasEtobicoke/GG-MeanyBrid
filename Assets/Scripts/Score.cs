﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [Header("Default Score")]
    public static int score = 0;

    public Text scoreText;

    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
