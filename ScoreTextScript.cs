using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTextScript : MonoBehaviour
{
    Text text;
    public int lvPicker;
    public static int coinAmount;
    public int maxCoinAmount;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = coinAmount.ToString();
        if (coinAmount == maxCoinAmount) 
        {
            SceneManager.LoadScene(lvPicker);
            coinAmount = 0;
        }
    }
}
