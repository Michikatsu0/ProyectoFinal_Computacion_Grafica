using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitcherEffect : MonoBehaviour
{
    public int selectedEffect;
    private bool uINextButton, uIPreviousButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SelectEffect();
    }

    void SelectEffect()
    {
        int i = 0;
        foreach (Transform effect in transform)
        {
            if (i == selectedEffect)
                effect.gameObject.SetActive(true);
            else
                effect.gameObject.SetActive(false);
            i++;
        }
    } 

    public void NextEffectButton()
    {
        if (selectedEffect >= transform.childCount - 1)
            selectedEffect = 0;
        else
            selectedEffect++;
    }

    public void PreviousEffectButton()
    {
        if (selectedEffect <= 0)
            selectedEffect = transform.childCount - 1;
        else
            selectedEffect--;
    }
}
