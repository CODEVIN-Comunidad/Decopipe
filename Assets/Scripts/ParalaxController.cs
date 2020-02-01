using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParalaxController : MonoBehaviour
{
    [Range(0f, 0.20f)]
    public float parallaxSpeed = 0.02f;
    public RawImage background1;


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        float finalSpeed = parallaxSpeed * Time.deltaTime;
        background1.uvRect = new Rect(background1.uvRect.x + finalSpeed, background1.uvRect.y + finalSpeed, 1f, 1f); 
    }
}
