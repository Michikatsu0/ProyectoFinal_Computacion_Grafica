using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseShaderController : MonoBehaviour
{
    [SerializeField] public Material shaderMaterial;
    [SerializeField] public List<InputField> uIVariables;
}
