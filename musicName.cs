using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class musicName : NAudioImporter
{
    public TextMeshProUGUI songName;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        songName.text=songname.ToString();
    }
}
