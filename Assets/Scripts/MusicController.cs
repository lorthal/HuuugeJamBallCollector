using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{

    public enum Track
    {
        Menu,
        Game
    }

    void Awake()
    {
        if (MusicController.instance == null)
        {
            source = GetComponent<AudioSource>();
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private AudioSource source;

    public AudioClip Menu, Game;

    private static MusicController instance;

    public static void ChangeTrack(Track track)
    {
        switch (track)
        {
            case Track.Menu:
                instance.source.clip = instance.Menu;
                instance.source.volume = 0.75f;
                break;
            case Track.Game:
                instance.source.clip = instance.Game;
                instance.source.volume = 0.1f;
                break;
        }
        instance.source.Play();

    }
}