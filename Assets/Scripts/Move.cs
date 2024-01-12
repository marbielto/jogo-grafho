using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{   
    public Transform target;
    public SpriteRenderer sr;

    

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, 3 * Time.deltaTime);

        if (transform.position.x > target.position.x)
            sr.flipX = false;
        else sr.flipX = true;
    }
}
