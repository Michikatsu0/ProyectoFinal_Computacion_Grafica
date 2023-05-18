using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherEffect : MonoBehaviour
{
    [SerializeField] private List<BaseShaderController> shaderMaterialHandler = new List<BaseShaderController>();
    private BaseShaderController previousShaderMaterial = null;
    [SerializeField] private BaseShaderController currentShaderMaterial; 
    private int selectedShaderEffect;

    private List<float> floatBuffer;
    private List<Color> colorBuffer;
    private List<Vector3> vector3Buffer;

    private void Start()
    {
        currentShaderMaterial = shaderMaterialHandler[0];
    }
    void Update()
    {
        SelectEffect();
    }

    void SelectEffect()
    {
        int i = 0;
        foreach (Transform effect in transform)
        {
            if (i == selectedShaderEffect)
                effect.gameObject.SetActive(true);
            else
                effect.gameObject.SetActive(false);
            i++;
        }
    }

    #region Switch Shader

    public void NextEffectButton()
    {
        if (selectedShaderEffect >= transform.childCount - 1)
            selectedShaderEffect = 0;
        else
            selectedShaderEffect++;
        previousShaderMaterial = currentShaderMaterial;
        currentShaderMaterial = shaderMaterialHandler[selectedShaderEffect];
    }

    public void PreviousEffectButton()
    {
        if (selectedShaderEffect <= 0)
            selectedShaderEffect = transform.childCount - 1;
        else
            selectedShaderEffect--;
        previousShaderMaterial = currentShaderMaterial;
        currentShaderMaterial = shaderMaterialHandler[selectedShaderEffect];
    }

    #endregion

    void ChargeVariables()
    {
        
    }

    void UnSubscribe()
    {
        //CurrentShaderMaterial?.Invoke(currentShaderMaterial.shaderMaterial);

    }
}
