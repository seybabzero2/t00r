using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aiShooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;

    void Update()
    {
        Shoot();
    }


    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Debug.Log("Shoot!");    
        //yield on a new YieldInstruction that waits for 5 seconds.
        //yield return new WaitForSecondsRealtime(1f);

        //After we have waited 5 seconds print the time again.
    }
}
