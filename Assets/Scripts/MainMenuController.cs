using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuController : MonoBehaviour {

    public Button StartButton, ControlsButton, AboutButton, ExitButton;
	// Use this for initialization
	void Start () {
        StartButton.onClick.AddListener(OnStart);
        ControlsButton.onClick.AddListener(OnControls);
        AboutButton.onClick.AddListener(OnAbout);
        ExitButton.onClick.AddListener(OnExit);
    }


    void OnStart()
    {
        SceneManager.LoadScene(1);
    }
    void OnControls()
    {

    }
    void OnAbout()
    {

    }
    void OnExit()
    {
        Application.Quit();
    }
}
