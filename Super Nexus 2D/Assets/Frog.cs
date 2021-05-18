using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    [SerializeField] private float leftCap;
    [SerializeField] private float rightCap;
    [SerializeField] private float jumplength = 10f;
    [SerializeField] private float jumpheight = 15f;
    [SerializeField] private LayerMask ground;
    private Collider2D coll;
    private Rigidbody2D rb;

    private bool facingLeft = true;

    private void Start()
    {
        coll = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(facingLeft)
        {
            if(transform.position.x > leftCap)
            {
                //make sure sprite is facing correctly, if not fface correctly
                if(transform.localScale.x != 1)
                {
                    transform.localScale = new Vector3(1, 1);
                }
                if(coll.IsTouchingLayers(ground))
                {
                    //jump
                    rb.velocity = new Vector2(-jumplength, jumpheight);
                }
                //test if touching grounf, if so jump
            }
            else
            {
                facingLeft = false;
            }
        }
        else
        {
            if(transform.position.x < rightCap)
            {
                if(transform.localScale.x != -1)
                {
                    transform.localScale = new Vector3(-1, 1);
                }
                if(coll.IsTouchingLayers(ground))
                {
                    //jump
                    rb.velocity = new Vector2(jumplength, jumpheight);
                }
            }
            else
            {
                facingLeft = true;
            }
        }
    }

}
