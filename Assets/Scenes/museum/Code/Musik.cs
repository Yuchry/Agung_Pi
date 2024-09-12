using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musik : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    void Start()
    {
        audioSource.Stop();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider Player){
        if (Player.gameObject.tag == "Player"){
            audioSource.Play();
        }
    }

    void OnTriggerExit(Collider Player){
        if (Player.gameObject.tag == "Player"){
            audioSource.Stop();
        }
    }
}
