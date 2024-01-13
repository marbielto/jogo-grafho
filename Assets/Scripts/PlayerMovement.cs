using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator anim;
    public float speed;
    private SpriteRenderer playerFlip;

    void Start()
    {
        playerFlip = GetComponent<SpriteRenderer>();

    }

    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);

        //float inputAxis = Input.GetAxis("Horizontal");

        /*if(inputAxis > 0)
        {
            transform.eulerAngles = new Vector2(0, 180f);
        }

        if(inputAxis < 0)
        {
            transform.eulerAngles = new Vector2(0, 0f);
        }*/


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerFlip.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerFlip.flipX = false;
        }

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Speed", movement.magnitude);

        transform.position = transform.position + movement * speed * Time.deltaTime;
    }

  
}
