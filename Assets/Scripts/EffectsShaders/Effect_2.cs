using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect_2 : BaseShaderController
{
    public ParticleSystem ParticleSystem;

    void Update()
    {
        if (float.TryParse(uIVariables[0].text, out float result))
        {
            shaderMaterial[0].SetFloat("_DistorsionScale", result);
        }

        if (float.TryParse(uIVariables[1].text, out float result1))
        {
            shaderMaterial[0].SetFloat("_DistorsionAmmount", result1);
        }

        if (float.TryParse(uIVariables[2].text, out float result2))
        {
            shaderMaterial[0].SetFloat("_TwirlStrength", result2);
        }

        if (float.TryParse(uIVariables[3].text, out float result3))
        {
            shaderMaterial[1].SetFloat("_FresnelPower", result3);
        }

        shaderMaterial[1].SetColor("_FresnelColor", SwitcherEffect.Instance.colorEffect1);
        var main = ParticleSystem.main;
        main.startColor = SwitcherEffect.Instance.colorEffect1;
    }

}
