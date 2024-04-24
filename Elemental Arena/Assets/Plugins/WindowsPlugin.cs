using System.Runtime.InteropServices;
using UnityEngine;

public class WindowsPlugin : MonoBehaviour
{
    [DllImport("MultiplyPlugin")]
    private static extern float Multiply(float a, float b);

    void Start()
    {
        // Передача чисел в плагин и получение результата
        float result = Multiply(3, 20);
        Debug.Log("Result of multiplication: " + result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
