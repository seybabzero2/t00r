using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D collision) 
    {
        var player = collision.GetComponent<PlayerBehavoir>();
        if (player) {
            player.TakeHit(1.0f);
            Debug.Log("damage!)");
        }
    }
}
