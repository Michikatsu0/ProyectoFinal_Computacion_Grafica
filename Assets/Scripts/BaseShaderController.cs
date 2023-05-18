using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseShaderController : MonoBehaviour
{
    public static Action<Material> CurrentShaderMaterial;

    [SerializeField] public Material shaderMaterial;

    public abstract void SetShaderInformation(Material shaderMaterial);
}
