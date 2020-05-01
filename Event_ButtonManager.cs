using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event_ButtonManager : MonoBehaviour
{
    public GameObject Image;
    public GameObject Audio;
    

    private float backVol = 1.0f;
    // Start is called before the first frame update
    public void ImageSetActive()
    {
        Image.SetActive(!Image.active);
    }

    public void AudioSetActive()
    {
        Audio.SetActive(!Audio.active);
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
