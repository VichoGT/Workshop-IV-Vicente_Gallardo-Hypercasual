using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject mainMenu;
     

    public void OpenOptionsPanel()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }
    public void OpenMainMenuPanel()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
    public void Jugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }
}
