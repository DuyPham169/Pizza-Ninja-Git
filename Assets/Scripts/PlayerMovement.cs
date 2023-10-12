using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float step = 1f;
    private bool disablePlay;

    public LayerMask stop;
    public LayerMask spotted;
    public int turn = 0;
    public GameObject restartObject;
    // Start is called before the first frame update
    void Start()
    {
        disablePlay = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!disablePlay)
        {
            // Movement
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y) + new Vector2(0, 1), .4f, stop))
                {
                    transform.Translate(Vector2.up * step);
                    turn++;
                }
            }
            else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y) + new Vector2(-1, 0), .4f, stop))
                {
                    transform.Translate(-Vector2.right * step);
                    transform.localScale = new Vector2(-1, 1);
                    turn++;
                }
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y) + new Vector2(0, -1), .4f, stop))
                {
                    transform.Translate(-Vector2.up * step);
                    turn++;
                }
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y) + new Vector2(1, 0), .4f, stop))
                {
                    transform.Translate(Vector2.right * step);
                    transform.localScale = new Vector2(1, 1);
                    turn++;
                }
            }

            // Check if spotted
            if (Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y), .4f, spotted))
            {
                turn--;
                StartCoroutine(Lose());
            }
        }
    }

    IEnumerator Lose()
    {
        disablePlay = true;

        yield return new WaitForSeconds(0.5f);

        restartObject.GetComponent<Restart>().RestartingLevel();
    }
}
