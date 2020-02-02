using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    //public float jumpForce;
    private Rigidbody2D rigidBody;

    // Start is called before the first frame update

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TouchYellow()
    {
        rigidBody.AddForce(transform.up * 4.5f, ForceMode2D.Impulse);
    }

    public void TouchBrown()
    {
        rigidBody.AddForce(transform.up * 8, ForceMode2D.Impulse);
    }

    public void TouchRed()
    {
        rigidBody.AddForce(transform.up * 7, ForceMode2D.Impulse);
    }

    public void TouchBlue()
    {
        rigidBody.AddForce(transform.up * 5, ForceMode2D.Impulse);
    }
}
