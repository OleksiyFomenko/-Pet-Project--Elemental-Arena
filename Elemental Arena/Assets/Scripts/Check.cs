using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Check : MonoBehaviour
       
{
    public TextMeshProUGUI text;


    // Start is called before the first frame update
    void Start()
    {
        text.text = PlayerPrefs.GetFloat("musicVolume").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
