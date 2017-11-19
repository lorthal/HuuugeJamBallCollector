using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartController : MonoBehaviour {

    public Button RestartButton, MenuButton;
	// Use this for initialization
	void Start () {
        RestartButton.onClick.AddListener(Restart);
        MenuButton.onClick.AddListener(GoToMenu);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        MusicController.ChangeTrack(MusicController.Track.Menu);
    }
}
