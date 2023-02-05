using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public int lvPicker;

    // Start is called before the first frame update
    public void Button() {
        SceneManager.LoadScene(lvPicker);
    }
}
