using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject settingPanelPrefab;
    // Start is called before the first frame update
    void Start()
    {
        SettingPanelOFF();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void SettingPanel(){
        settingPanelPrefab.SetActive(true);
    }
    public void SettingPanelOFF(){
        settingPanelPrefab.SetActive(false);
    }
    public void Quit(){
        Debug.Log("we out");
        Application.Quit();
    }
}
