using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollowing : MonoBehaviour
{
    
    public GameObject player;
    public float speed;
    public float distanceBetween;

    private float distance;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + -90;
        float newangle = angle + 150f;
        if (distance < distanceBetween) {    
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }
    }

    void OnTriggerEnter2D(Collider2D collision) 
    {
        var player = collision.GetComponent<PlayerBehavoir>();
        if (player) {
            player.TakeHit(1);
            Debug.Log("damage!)");
        }
    }

    IEnumerator TimeDelay() 
    {
        yield return new WaitForSeconds(2);

    }
}
