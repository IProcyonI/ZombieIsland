using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuKontrolu : MonoBehaviour
{
    public static bool gameIsPause=false;
    public GameObject PauseMenu;
    public GameObject OptionsMenu;
    public GameObject panel;
    public AudioSource arkaplan;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!gameIsPause)
            {
                Pause();               
            }
            
        }
    }
    public void Resume()
    {
        PauseMenu.SetActive(false);
        panel.SetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
    }
    public void Pause()
    {
        PauseMenu.SetActive(true);
        panel.SetActive(true);
        Time.timeScale = 0f;
        gameIsPause = true;
    }
    public void LoadSceane()
    {
        SceneManager.LoadScene("OyunBasladý");
        
    }

    public void ShowOptions()
    {
        
        PauseMenu.SetActive(false);
        OptionsMenu.SetActive(true);      
        gameIsPause = true;
    }

    public void SetQuality(int qual)
    {
        QualitySettings.SetQualityLevel(qual);
    }

    public void SetFullScreen(bool setfull)
    {
        Screen.fullScreen = setfull;
    }

    public void SetMusic(bool musicfull)
    {
        arkaplan.mute = !musicfull;
    }
}

