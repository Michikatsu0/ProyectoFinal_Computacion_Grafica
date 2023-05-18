using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSingEvent : MonoBehaviour
{
    public static SliderSingEvent instance;
    public Slider slider;
    public Color colorEffect;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        colorEffect = Color.HSVToRGB(slider.value/slider.maxValue, 1, 1);
    }
}
