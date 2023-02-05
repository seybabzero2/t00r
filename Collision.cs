using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject hitEffect;


    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        var enemy = collision.collider.GetComponent<EnemyBehevoir>();
        if (enemy) {
            enemy.TakeHit(1);

        }
        Destroy(effect, 5f);
        Destroy(gameObject);

        

    }
}
