using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject effect;

    public float bulletForce = 20f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            Camera.main.orthographicSize = 9.0f;
            StartCoroutine(Shoot());
        }
    }


    IEnumerator Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Instantiate(effect, firePoint.position, firePoint.rotation);
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSecondsRealtime(0.3f);

        //After we have waited 5 seconds print the time again.
        Camera.main.orthographicSize = 10.0f;
    }
}
