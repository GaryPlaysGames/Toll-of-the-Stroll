using UnityEngine;
using UnityEngine.UI; //use UI elements (i.e. Sliders, Buttons, Text, ETC)
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class UIManager : MonoBehaviour {

    public GameObject pausePanel;
    public Slider volumeControl;
    public GameObject FPSController;

    public bool isPaused;

	void Start ()
    {
        isPaused = false;
        Cursor.lockState = CursorLockMode.Confined; //Not working right now
    }
	
	void Update ()
    {
        PauseGame(isPaused); //Pauses the game based on the value of isPaused

        if (Input.GetButtonDown("Cancel"))
        {
            SwitchPause();
        }
	}

    void PauseGame(bool state)
    {
        if (state)
        {
            Time.timeScale = 0.0f; //Paused
        }

        else
        {
            Time.timeScale = 1.0f; //Unpaused
        }

        pausePanel.SetActive(state);
        FPSController.GetComponent<FirstPersonController>().enabled = !state;
        Cursor.visible = state;

        AudioListener.volume = volumeControl.value;

        if (state)
        {
            Cursor.lockState = CursorLockMode.None;
        }

        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        
    }

    public void SwitchPause()
    {
        if (isPaused)
        {
            isPaused = false;
        }

        else
        {
            isPaused = true;
        }
    }

}
