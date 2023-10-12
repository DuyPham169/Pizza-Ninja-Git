using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float step = 1f;
    public LayerMask stop;
    public int turn = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y) + new Vector2(0, 1), .4f, stop)) 
            {
                transform.Translate(Vector2.up * step);
                turn++;
            }
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y) + new Vector2(-1, 0), .4f, stop))
            {
                transform.Translate(-Vector2.right * step);
                transform.localScale = new Vector2(-1, 1);
                turn++;
            }
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y) + new Vector2(0, -1), .4f, stop))
            {
                transform.Translate(-Vector2.up * step);
                turn++;
            }
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y) + new Vector2(1, 0), .4f, stop))
            {
                transform.Translate(Vector2.right * step);
                transform.localScale = new Vector2(1, 1);
                turn++;
            }
        }
    }
}
