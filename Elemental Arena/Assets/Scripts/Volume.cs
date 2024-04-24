using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{

    [SerializeField] private AudioSource m_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            m_AudioSource.volume = PlayerPrefs.GetFloat("musicVolume");
        }        
    }
}
