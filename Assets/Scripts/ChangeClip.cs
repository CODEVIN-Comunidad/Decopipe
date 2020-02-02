using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * This script is used to change the clip of audio source of the MainScene
 */


public class ChangeClip : MonoBehaviour
{

    private GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if(!canvas.GetComponent<AudioSource>().isPlaying)
        {
            SceneManager.LoadScene("Level 1");
        }
    }

    //This method change the audioclip after push a button
    public void ChangeAudio()
    {
        GameObject.Find("Button").SetActive(false);
        GameObject.Find("Text").SetActive(false);
        canvas.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("Music/Hit trompetas");
        canvas.GetComponent<AudioSource>().Play();
        canvas.GetComponent<AudioSource>().loop = false;
    }
}
