using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossScript : MonoBehaviour
{
    

    void OnTriggerEnter2D(Collider2D collision) 
    {
        var player = collision.GetComponent<PlayerBehavoir>();
        if (player) {
            player.TakeHit(1.0f);
            Debug.Log("damage!)");
        }
    }
}
