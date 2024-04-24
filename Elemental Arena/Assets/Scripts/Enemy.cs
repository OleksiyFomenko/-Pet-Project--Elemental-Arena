using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{    
    [SerializeField] private int[] damage = { 3, 5, 1 };
    private GameObject player;
    public string sceneName;

    public int hitpoints = 5;
    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Character");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        gameObject.transform.position += (lookDirection * speed * Time.deltaTime);
        if (hitpoints <= 0)
        {
            if (gameObject.tag == "Boss")
            {
                PlayerInfo.level++;
                NextLevel(sceneName);
            }
            Destroy(gameObject);
        }
    }

    public void NextLevel(string name)
    {
        SceneManager.LoadScene(name);
    }
    private void OnTriggerEnter(Collider other)
    {
        string element = PlayerPrefs.GetString("staffChouse");
        if (other.tag != "Player")
        switch (element)
        {
            case "frost":
                hitpoints = hitpoints - damage[0];
                break;
            case "earth":
                hitpoints = hitpoints - damage[1];
                break;
            case "wind":
                hitpoints = hitpoints - damage[2];
                break;
        }     
        
    }
}
