﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int coins;
    public Text coinsText;

    private void Update()
    {
        coinsText.text = "Coins: " + coins;
    }

}
