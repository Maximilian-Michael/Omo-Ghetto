﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}
