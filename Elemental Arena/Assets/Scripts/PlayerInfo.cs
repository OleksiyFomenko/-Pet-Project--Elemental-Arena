using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class PlayerInfo : MonoBehaviour
{

    [SerializeField] GameObject character;
    public float health;
    private float maxHealth = 100;
    [SerializeField] GameObject healsBar;
    [SerializeField] TextMeshProUGUI hitpointsText;


    public static float level = 1;

    [System.Serializable]
    public class MyData
    {
        public float playerLevel = PlayerInfo.level;
    }

    public static MyData data;

    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        health = maxHealth;
    }   

    // Update is called once per frame
    void Update()
    {
        hitpointsText.text = "Hitpoints: " + Math.Round(health);
        healsBar.transform.localScale = new Vector3(health / 100, healsBar.transform.localScale.y);
        if (health <= 0)
        {
            level = 1;
            SceneManager.LoadScene("MainMenu");
            SaveData();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            health -= 0.1f;
        }
        if (other.gameObject.tag == "Boss")
        {
            health -= 0.5f;
        }
    }

    public static void SaveData()
    {
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/data.json", json);
        Debug.Log(Application.persistentDataPath + "/data.json");
        Debug.Log("Save complite");
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/data.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            data = JsonUtility.FromJson<MyData>(json);
        }
        else
        {
            Debug.LogWarning("JSON file not found!");
        }
    }

}
