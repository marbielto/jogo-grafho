using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{   
    public Animator anim;
    int side = -1;
    public Transform bullet;
    public Transform pivot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            side = 1;
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            side = -1;
 
        transform.localScale = Vector2.right * side;

        if (Input.GetKeyDown(KeyCode.Space))
        {   
            anim.SetTrigger("attack");
            Transform obj = Instantiate(bullet, pivot.position, transform.rotation);
            obj.right = Vector2.right * side;
            

        }
    }
}
