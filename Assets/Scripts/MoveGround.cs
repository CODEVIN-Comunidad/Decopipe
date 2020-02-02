using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveGround : MonoBehaviour
{
    [Range(-30.0f, 0.0f)]
    public float moveSpeed =-5f;
    public Grid tilemap;
   
    private float finalSpeed;
    public static int state;
    private GameObject startButton;
    // Start is called before the first frame update
    void Start()
    {
        state = 0;
        startButton = GameObject.Find("StartButton");
    }

    // Update is called once per frame
    void Update()
    {
        if (state == 1)
        {
            ParallaxMoveGround();
            startButton.SetActive(false);
        }

        if(GameObject.Find("Player").transform.position.x <= -4)
        {
            state = 3;
        }

        if(state == 3)
        {
            TriggerEvent.backgroundMusic.clip = Resources.Load<AudioClip>("Music/Muerte personaje");
            TriggerEvent.backgroundMusic.loop = false;
            TriggerEvent.backgroundMusic.Play();
            SceneManager.LoadScene("Main Scene");
        }
    }

    public void StartGame()
    {
        state = 1;
    }

    private void ParallaxMoveGround()
    {
        finalSpeed = moveSpeed * Time.deltaTime;
        tilemap.transform.position = new Vector3(tilemap.transform.position.x + finalSpeed, tilemap.transform.position.y);
    }
}
