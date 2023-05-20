using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SwitcherEffect : MonoBehaviour
{
    public static SwitcherEffect Instance;
    [SerializeField] private List<GameObject> panelEffects = new List<GameObject>();
    [SerializeField] private List<BaseShaderController> shaderMaterialHandler = new List<BaseShaderController>();
    [SerializeField] private List<Slider> slider;
    [SerializeField] public Color colorEffect1, colorEffect2;

    [SerializeField] private BaseShaderController currentShaderMaterial;
    private BaseShaderController previousShaderMaterial = null;

    private int selectedShaderEffect;
    private List<float> floatBuffer;
    private List<Color> colorBuffer;
    private List<Vector3> vector3Buffer;

    private void Start()
    {
        Instance = this;
        currentShaderMaterial = shaderMaterialHandler[0];
    }
    void Update()
    {
        SelectEffect();
        colorEffect1 = Color.HSVToRGB(slider[0].value / slider[0].maxValue, 1, 1);
        colorEffect2 = Color.HSVToRGB(slider[1].value / slider[1].maxValue, 1, 1);
    }

    void SelectEffect()
    {
        int f = 0;
        foreach (Transform effect in transform)
        {
            if (f == selectedShaderEffect)
                effect.gameObject.SetActive(true);
            else
                effect.gameObject.SetActive(false);
            f++;
        }
        int p = 0;
        foreach (GameObject effect in panelEffects)
        {
            if (p == selectedShaderEffect)
                effect.SetActive(true);
            else
                effect.SetActive(false);
            p++;
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

}
