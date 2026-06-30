using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    public GameObject instructionsMenu;
    public GameObject mainMenu;
     

    public void OpenInstrucsPanel()
    {
        Debug.Log("Se abre");
        mainMenu.SetActive(false);
        instructionsMenu.SetActive(true);
    }
    public void OpenMainMenuPanel()
    {
        mainMenu.SetActive(true);
        instructionsMenu.SetActive(false);
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
