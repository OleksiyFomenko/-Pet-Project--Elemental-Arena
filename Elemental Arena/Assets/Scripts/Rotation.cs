using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private float rotation_y = 100;
    [SerializeField] private float rotation_x = 40;
    [SerializeField] private float size_x = 5;
    [SerializeField] private float size_y = 10;
    [SerializeField] private float size_z = 20;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube.transform.Rotate(rotation_x * Time.deltaTime, rotation_y * Time.deltaTime, 0);
        cube.transform.localScale += new Vector3(size_x, size_y, size_z) * Time.deltaTime;
    }
}
