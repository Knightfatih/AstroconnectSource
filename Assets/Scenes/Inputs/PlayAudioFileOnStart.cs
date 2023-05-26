using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioFileOnStart : MonoBehaviour
{
    private AudioSource audiosource;

    // Start is called before the first frame update
    void Start()
    {
        audiosource = gameObject.GetComponent<AudioSource>();
        audiosource.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
