using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect_1 : BaseShaderController
{
    // SwitcherEffect.Instance.colorEffect; para acceder al color del slider
    public ParticleSystem[] pSystem;

    void Update()
    {
        foreach (var ps in pSystem)
        {
            var main = ps.main;
            main.startColor = SwitcherEffect.Instance.colorEffect1;
        }
        shaderMaterial[0].SetColor("_Color", SwitcherEffect.Instance.colorEffect1);
        
        if (float.TryParse(uIVariables[0].text, out float result))
        {
            var mian = pSystem[pSystem.Length - 2].main;
            mian.startSize = result;
        }
    }
}
