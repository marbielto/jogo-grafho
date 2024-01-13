using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemie : MonoBehaviour
{   
    public Transform target;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, 3 * Time.deltaTime);
        if(transform.position.x <= target.transform.position.x)
        {
            sr.flipX = false;
        }
        if(transform.position.x > target.transform.position.x)
        {
            sr.flipX = true;
        }
    }

    public void itsDied()
    {
        Destroy(gameObject);
    }

}
