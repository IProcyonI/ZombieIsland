using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunBasla : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;       
    }

    // Update is called once per frame
    public void OyunBaslat()
    {      
        SceneManager.LoadScene("SampleScene");               
    }
    public void C�k�s()
    {
        Application.Quit();
    }
}
