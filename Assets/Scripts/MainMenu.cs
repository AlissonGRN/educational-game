using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void QuitGame() {
         
        Debug.Log("Saiu do jogo");
        Application.Quit();
    }
}
