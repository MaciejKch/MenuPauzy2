using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPauzy : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;

    [SerializeField] private bool isPaused;

   private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if (isPaused)
        {
            Pauza();
        }

        else
        {
            Wróć();
        }
    }

    void Pauza()
    {
        Time.timeScale = 0;
       
        pauseMenuUI.SetActive(true);
    }

    public void Wróć()
    {
        Time.timeScale = 1;

        pauseMenuUI.SetActive(false);
    }

    public void Zapisz()
    {
        Debug.Log("Zapisz");
    }

    public void Wczytaj()
    {
        Debug.Log("Wczytaj");
    }

    public void Opcje()
    {
        Debug.Log("Opcje");
    }

    public void WyjdźDoMenu()
    {
        Debug.Log("Wyjdź do menu");
    }

    public void WyjdźZGry()
    {
        Debug.Log("Wyjdź z gry");
    }
}
