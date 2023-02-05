using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    
    public GameObject effect;


    void OnTriggerEnter2D(Collider2D col) 
    {
        ScoreTextScript.coinAmount += 1;
        Instantiate(effect, transform.position, transform.rotation);
        Destroy (gameObject);
    }

}
