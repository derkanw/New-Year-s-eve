using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioClip hightlight, press;
    public AudioSource manager;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnButton()
    {
        manager.PlayOneShot(hightlight);
    }

    public void OnClick()
    {
        manager.PlayOneShot(press);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
