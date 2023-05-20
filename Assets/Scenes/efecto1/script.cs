using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public ParticleSystem pSiteamMain;
    public ParticleSystem pSiteamSphere;
    public ParticleSystem pSiteamLigth;
    public ParticleSystem pSiteamInv;
    //variable que controla en color
    public Color colorControler;
    //Variable que controla el tamaño del pato
    public float sizeMltiplier; 
 
    void Start()
    {
        
        pSiteamMain = GameObject.Find("spiral").GetComponent<ParticleSystem>();

        pSiteamSphere = GameObject.Find("sphere").GetComponent<ParticleSystem>();
        pSiteamLigth = GameObject.Find("liogth").GetComponent<ParticleSystem>();
        pSiteamInv =  GameObject.Find("invocation").GetComponent<ParticleSystem>();
    }

    void Update()
    {
        colorControler = Color.red;

        var mainL = pSiteamLigth.main;
        mainL.startColor = colorControler;


        var mainS = pSiteamSphere.main;
        mainS.startColor = colorControler;

        var mainM = pSiteamMain.main;
        mainM.startColor = colorControler;

        var sizeInv = pSiteamInv.main;
        sizeInv.startSize =  sizeMltiplier;
        
        
    }
  
}
