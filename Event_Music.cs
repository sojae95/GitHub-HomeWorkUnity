using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event_Music : MonoBehaviour
{
    public Slider BackVolume;
    private AudioSource Audio;

    public float BackVol = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.Audio = this.gameObject.GetComponent<AudioSource>();
        this.Audio.loop = false;
        Audio.volume = BackVolume.value;
    }

    // Update is called once per frame
    void Update()
    {
        Audio.volume = BackVolume.value;
        BackVol = BackVolume.value;
    }
}
