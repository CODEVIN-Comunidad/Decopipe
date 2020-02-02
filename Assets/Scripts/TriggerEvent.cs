using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerEvent : MonoBehaviour
{
    private GameObject yellow;
    private GameObject brown;
    private GameObject red;
    private GameObject blue;
    private AudioSource jumpTrumpet;

    public static float jump;

    // Start is called before the first frame update
    void Start()
    {
        yellow = GameObject.Find("YellowButton");
        brown = GameObject.Find("BrownButton");
        red = GameObject.Find("RedButton");
        blue = GameObject.Find("BlueButton");
        jumpTrumpet = GameObject.Find("Grid").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TouchYellow()
    {
        jump = 5;
        OnCollisionEnter2D();
        jumpTrumpet.clip = Resources.Load<AudioClip>("Music/Botón 2");
        jumpTrumpet.Play();
    }

    public void TouchBrown()
    {
        jump = 10;
        OnCollisionEnter2D();
        jumpTrumpet.clip = Resources.Load<AudioClip>("Music/Botón 4");
        jumpTrumpet.Play();
    }

    public void TouchRed()
    {
        jump = 8;
        OnCollisionEnter2D();
        jumpTrumpet.clip = Resources.Load<AudioClip>("Music/Botón 1");
        jumpTrumpet.Play();
    }

    public void TouchBlue()
    {
        jump = 6;
        OnCollisionEnter2D();
        jumpTrumpet.clip = Resources.Load<AudioClip>("Music/Botón 3");
        jumpTrumpet.Play();
    }

    private void OnCollisionEnter2D()
    {
        yellow.GetComponent<Button>().enabled = false;
        brown.GetComponent<Button>().enabled = false;
        red.GetComponent<Button>().enabled = false;
        blue.GetComponent<Button>().enabled = false;

        yellow.GetComponent<Image>().enabled = false;
        brown.GetComponent<Image>().enabled = false;
        red.GetComponent<Image>().enabled = false;
        blue.GetComponent<Image>().enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Flag")
        {
            Debug.Log("Ouch");
            yellow.GetComponent<Button>().enabled = true;
            brown.GetComponent<Button>().enabled = true;
            red.GetComponent<Button>().enabled = true;
            blue.GetComponent<Button>().enabled = true;

            yellow.GetComponent<Image>().enabled = true;
            brown.GetComponent<Image>().enabled = true;
            red.GetComponent<Image>().enabled = true;
            blue.GetComponent<Image>().enabled = true;

        }
    }
}
