using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehevoir : MonoBehaviour
{

    public float Hitpoints;
    public float MaxHitpoints = 5;
    public GameObject effect;
    public GameObject coin;

    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitpoints;
    }

    // Update is called once per frame
    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        if (Hitpoints <= 0)
        {
            //Vector2 tempTransform;
            // = new Vector2(Random.Range(-5.0f, 5.0f), Random.Range(5.0f, 5.0f));
            EnemyText.enemyAmount = EnemyText.enemyAmount + 1;
   
            Instantiate(effect, transform.position, transform.rotation);
            Instantiate(coin, transform.position, transform.rotation);

            Destroy(gameObject);
        }
    }
}
