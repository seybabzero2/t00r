using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DiamondScript : MonoBehaviour
{
    public GameObject effect;
    public int lvPicker;
    public int amount = 6;

    void OnTriggerEnter2D(Collider2D col) 
    {
        //HealthTextScore.healthAmount += 1;\
        if (ScoreTextScript.coinAmount >= amount) {
            Instantiate(effect, transform.position, transform.rotation);
            SceneManager.LoadScene(lvPicker);
            Destroy (gameObject);
        }
    }
}
