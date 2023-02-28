using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusicScript : MonoBehaviour
{
    public AudioSource music;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        music = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (music.isPlaying) return;
        music.Play();
    }

    public void StopMusic()
    {
        music.Stop();
    }
}

