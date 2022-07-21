using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pavimento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        posIniziale = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = posIniziale; 
        if (Input.G)
    }

    Vector2 posIniziale; 
}
