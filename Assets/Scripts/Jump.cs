using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public float jumpForce;
    private Rigidbody2D rigidbody;

    // Start is called before the first frame update

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        jumpForce = TriggerEvent.jump;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Jumping()
    {
        rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        /*if (Input.GetButtonDown("YellowButton"))
        {
            rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
        if (Input.GetButtonDown("BrownButton"))
        {
            rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
        if (Input.GetButtonDown("RedButton"))
        {
            rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
        if (Input.GetButtonDown("BlueButton"))
        {
            rigidbody.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }*/
    }
}
