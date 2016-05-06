using UnityEngine;
using UnityEngine.UI; //use UI elements (i.e. Sliders, Buttons, Text, ETC)
using UnityStandardAssets.Characters.FirstPerson;
using System.Collections;

public class UIManager : MonoBehaviour {

    public GameObject pausePanel;
    public GameObject FPSController;

    public bool isPaused;

	void Start ()
    {
        isPaused = false;
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
