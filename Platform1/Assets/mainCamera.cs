using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       // posIniziale = transform.position;
        posizionePgPrimaMovimento = pgStandard.posizionePersonaggio;
    }

    // Update is called once per frame
    void Update()
    {
        if (pgStandard.posizionePersonaggio != posizionePgPrimaMovimento){ //cioè se si è mosso il personaggio, allora aggiorna anche la posizione della camera

        transform.position = pgStandard.posizionePersonaggio; 
        }
    
    }

    Vector2 posIniziale; 
    Vector2 posizionePgPrimaMovimento; 
    Vector2 posizionePgDopoMovimento; 
}
