using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseShaderController : MonoBehaviour
{
    [SerializeField] public List<Material> shaderMaterial;
    [SerializeField] public List<TMP_InputField> uIVariables;
}
