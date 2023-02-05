using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavoir : MonoBehaviour
{

    public float Hitpoints;
    public float MaxHitpoints = 5;
    public GameObject effect;
    public int lvPicker;
    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitpoints;
        HealthTextScore.healthAmount = 5;
    }   

    // Update is called once per frame
    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        HealthTextScore.healthAmount = HealthTextScore.healthAmount - 1;
        Instantiate(effect, transform.position, transform.rotation);
        if (Hitpoints <= 0)
        {
            
            //Instantiate(coin, transform.position, transform.rotation);
            ScoreTextScript.coinAmount = 0;
            Destroy(gameObject);
            SceneManager.LoadScene(lvPicker);
        }
    }
}
