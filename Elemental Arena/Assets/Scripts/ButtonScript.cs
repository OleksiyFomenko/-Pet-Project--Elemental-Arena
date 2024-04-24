
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public string sceneName = "Arena";
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(string sceneName)
    {
        PlayerInfo.SaveData();
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1;
    }

    public void Exit()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }

    public void PanelOpen()
    {
        panel.SetActive(true);
    }
    public void PanelClose() 
    {
        panel.SetActive(false);
    }

    public void StaffChouse(string element)
    {
        PlayerPrefs.SetString("staffChouse", element);
    }

    public void Continue()
    {
        Time.timeScale = 1.0f;
    }

}