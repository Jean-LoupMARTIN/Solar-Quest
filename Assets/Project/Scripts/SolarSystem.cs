﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SolarSystem : MonoBehaviour
{
    public static SolarSystem inst;

    public Slider speedSlider;
    [HideInInspector] public float speed = 1;

    public UnityEvent discoverEvent;
    [HideInInspector] public List<Astre> unknowAstres;

    void Awake() { inst = this; }


    void Update()
    {
        UpdateSpeed();
    }

    private void UpdateSpeed() => speed = Mathf.Pow(speedSlider.value, 2);

    public void Discover()
    {
        if (unknowAstres.Count > 0) {
            unknowAstres[0].Discorver();
            unknowAstres.RemoveAt(0);
            discoverEvent.Invoke();
        }
    }


}
