using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class musicPlayer : MonoBehaviour
{
    
   
  
   public GameObject music_chooser_panel;
    
    // Start is called before the first frame update
    void Start()
    {

   
   music_chooser_panel.SetActive(false);
    
    
      

    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.C)){
            
            MusicAdd();
        }
        if(Input.GetKeyDown(KeyCode.V)){
             
            MusicAddOff();
        }
      
      
        
    }
    public void MusicAdd(){

        pause();
        if(music_chooser_panel!=null){
            music_chooser_panel.SetActive(true);
        }
    }
     public void MusicAddOff(){

        
        if(music_chooser_panel!=null){
            
            music_chooser_panel.SetActive(false);
            Play();
            

        }
    }
    public void pause(){
        Time.timeScale=0f;
    }
     public void Play(){
        Time.timeScale=1f;
    }
    
}
