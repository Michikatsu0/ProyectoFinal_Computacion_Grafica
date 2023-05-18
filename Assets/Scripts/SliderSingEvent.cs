using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSingEvent : MonoBehaviour
{
    public Slider slider;
    public Color colorEffect;

    void Update()
    {
        colorEffect = Color.HSVToRGB(slider.value/slider.maxValue, 1, 1);
    }
   
}
