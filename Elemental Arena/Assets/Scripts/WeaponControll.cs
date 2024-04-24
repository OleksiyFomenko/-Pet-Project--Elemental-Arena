using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControll : MonoBehaviour
{
    [SerializeField] private string staffElement;
    [SerializeField] private string element;
    [SerializeField] private GameObject staff;


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("staffChouse"))
        {
            element = PlayerPrefs.GetString("staffChouse");
        }
        else
        {
            element = "frost";
        }
        LoadWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadWeapon()
    {
        if (element == staffElement)
        {
            staff.SetActive(true);
        }
        else
        {
            staff.SetActive(false);
        }
    }
}
