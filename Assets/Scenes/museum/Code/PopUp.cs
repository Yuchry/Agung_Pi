using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUp : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject info;
    void Start()
    {
        info.SetActive (false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider Player){
        if (Player.gameObject.tag == "Player"){
            info.SetActive (true);
        }
    }

    void OnTriggerExit(Collider Player){
        if (Player.gameObject.tag == "Player"){
            info.SetActive (false);
        }
    }
}
