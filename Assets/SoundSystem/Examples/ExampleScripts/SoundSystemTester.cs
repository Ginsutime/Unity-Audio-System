﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SoundSystem;

public class SoundSystemTester : MonoBehaviour
{
    [SerializeField] MusicEvent songA;
    [SerializeField] MusicEvent songB;
    [SerializeField] MusicEvent songC;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            songA.Play(2.5f);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            songB.Play(2.5f);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            songC.Play(2.5f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MusicManager.Instance.DecreaseLayerIndex(5);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MusicManager.Instance.IncreaseLayerIndex(5);
        }
    }
}