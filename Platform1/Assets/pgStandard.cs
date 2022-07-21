using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pgStandard : MonoBehaviour
{

// Start is called before the first frame update
    void Start()
    {
        trasform=false;
        rb = GetComponent<Rigidbody2D>();
        posizionePersonaggio = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {

        //comandi tastiera 
        if (Input.GetKeyDown("space")){
            if (Input.GetKey("right")){
                rb.velocity = new Vector2(-6f, 9f); 
                posizionePersonaggio = transform.position; 
            }
            rb.velocity = new Vector2(0f, 9f); 
        }

        if (Input.GetKey("right")){
            rb.velocity = new Vector2(6f, 0f); 
        }

        if (Input.GetKey("left")){
            rb.velocity = new Vector2(-6f, 0f); 
        }
        

    }

    bool trasform; 
    Rigidbody2D rb;
    public static Vector2 posizionePersonaggio;
}
