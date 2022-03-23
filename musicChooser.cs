using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[RequireComponent(typeof(AudioSource))]
public class musicChooser : MonoBehaviour
{ 
    public AudioClip[] clips;
     private string musicDir = "C:/Users/kingb/Music";
     AudioSource source;
 
     void Awake ()
     {
         source = GetComponent<AudioSource> ();
     }
 
     void Start ()
     {
        
     }
     public void play(){
          AudioClip selectedClip = clips [Random.Range (0, clips.Length)];
         string selCLip= selectedClip.ToString();
         WWW audioLoader = new WWW ("file://" + musicDir + selCLip);
         selectedClip= audioLoader.GetAudioClip (false, false, AudioType.WAV);
         source.clip = selectedClip;
         Debug.Log (source.clip.name);
     }
}
