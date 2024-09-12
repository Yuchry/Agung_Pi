using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        //memanggil scene yang ada di array 1 yaitu scene museum
        // bisa juga di panggil make nama contoh 
        // SceneManager.LoadScene("Museum Fathi");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
