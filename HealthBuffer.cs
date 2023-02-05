using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBuffer : MonoBehaviour
{

    public GameObject effect;

    void OnTriggerEnter2D(Collider2D col) 
    {
        HealthTextScore.healthAmount += 1;
        Instantiate(effect, transform.position, transform.rotation);
        Destroy (gameObject);
    }
}
