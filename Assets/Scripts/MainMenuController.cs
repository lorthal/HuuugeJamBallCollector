using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuController : MonoBehaviour {

    public Button StartButton, AboutButton, ExitButton;
	// Use this for initialization
	void Start () {
        StartButton.onClick.AddListener(OnStart);
        AboutButton.onClick.AddListener(OnAbout);
        ExitButton.onClick.AddListener(OnExit);
    }


    void OnStart()
    {
        SceneManager.LoadScene(1);
    }
    void OnAbout()
    {

    }
    void OnExit()
    {
        Application.Quit();
    }
}
