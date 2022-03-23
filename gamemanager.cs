using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject settingINGame;
    bool settingON;
    int settingbutton;
    
    // Start is called before the first frame update
    void Start()
    {
       settingbutton=1;
    }

    // Update is called once per frame
    void Update()
    {
        if(settingbutton%2==0){
            settingInGame();

        }
        if(settingbutton%2!=0){
            settingInGameOFF();

        }
        if(settingbutton==100){
            settingbutton=0;
        }
        
    }
    public void buttonEvenOrODD(){
        settingbutton++;
    }
    void settingInGame(){
        Time.timeScale=0;
         settingINGame.SetActive(true);
    }
    void settingInGameOFF(){
        Time.timeScale=1f;
         settingINGame.SetActive(false);
    }
}
