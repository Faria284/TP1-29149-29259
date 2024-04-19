using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BallScript : MonoBehaviour
{

    public AudioSource audioPlayerBound;

    public AudioSource miniBumperAudio;

    public AudioSource BumperAudio;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Bound"))
        {
            audioPlayerBound.Play();
        }
        else if(collision.gameObject.CompareTag("MiniBumper"))
        {
            miniBumperAudio.Play();
        }
        else if(collision.gameObject.CompareTag("Bumper"))
        {
            BumperAudio.Play();
        }
    } 
}
