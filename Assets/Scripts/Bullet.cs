using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(transform.right * 1000);
        Destroy(gameObject, 2); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.gameObject.tag == "Enemy")
        {
            
            collision.gameObject.GetComponent<MoveEnemie>().itsDied();
            Score.scoreCount += 1;
            
        }

        Destroy(gameObject);
    }
    
}
