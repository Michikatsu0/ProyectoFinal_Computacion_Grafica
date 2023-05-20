using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect_3 : BaseShaderController
{
    
    void Update()
    {
        if (float.TryParse(uIVariables[0].text, out float result))
        {
            shaderMaterial[0].SetFloat("_Noise_Strength", result);
        }

        if (float.TryParse(uIVariables[1].text, out float result1))
        {
            shaderMaterial[0].SetFloat("_Cut_Heigth", result1);
        }

        if (float.TryParse(uIVariables[2].text, out float result2))
        {
            shaderMaterial[1].SetFloat("_Noise_Strength", result2);
        }

        if (float.TryParse(uIVariables[3].text, out float result3))
        {
            shaderMaterial[1].SetFloat("_Edge_W", result3);
        }

        shaderMaterial[0].SetColor("_Color_Glow", SwitcherEffect.Instance.colorEffect1);
        shaderMaterial[1].SetColor("_Color_Glow", SwitcherEffect.Instance.colorEffect1);
        shaderMaterial[1].SetColor("_Color2", SwitcherEffect.Instance.colorEffect2);        
    }
}
