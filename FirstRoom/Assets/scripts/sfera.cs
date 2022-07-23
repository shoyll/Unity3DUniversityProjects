using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sfera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;

    /*
        posInit = GetComponent<Transform>(); // è una variabile Transorm
        // pos = (Transform) GetComponent(typeof(Transform)); forma alternativa 
    */  
       
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        if (Input.anyKey)
        Debug.Log(pos);
        
        if (Input.GetMouseButtonDown(0)) {
            pos = new Vector3(0, 0, (pos.z + 1));
        }
      
    }


    //variabile di istanza
    
    public Vector3 pos;
    
    //public Transform posInit;
    //public Transform pos; 
    //public float moveSpeed;
    //public float turnSpeed;
    //public GameObject cube;
}
