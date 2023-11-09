using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BetaMovement : MonoBehaviour
{
    private float step = 1f;
    private bool disablePlay;

    public LayerMask stop;
    public LayerMask spotted;
    public bool confirmedMove;
    public int turn = 0;
    public string sceneName;

    public SpriteRenderer render;
    public Sprite spriteUp;
    public Sprite spriteDown;
    public Sprite spriteHorizontal;
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
            confirmedMove = false;
            // Movement
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y) + new Vector2(0, 1), .4f, stop))
                {
                    render.sprite = spriteUp;
                    transform.Translate(Vector2.up * step);
                    turn++;
                }
            }
            else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y) + new Vector2(-1, 0), .4f, stop))
                {
                    render.sprite = spriteHorizontal;
                    transform.Translate(-Vector2.right * step);
                    transform.localScale = new Vector2(-1, 1);
                    turn++;
                }
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y) + new Vector2(0, -1), .4f, stop))
                {
                    render.sprite = spriteDown;
                    transform.Translate(-Vector2.up * step);
                    turn++;
                }
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                if (!Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y) + new Vector2(1, 0), .4f, stop))
                {
                    render.sprite = spriteHorizontal;
                    transform.Translate(Vector2.right * step);
                    transform.localScale = new Vector2(1, 1);
                    turn++;
                }
            }

            // Check if spotted
            if (Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y), .4f, spotted))
            {
                StartCoroutine(Lose());
            } else
            {
                confirmedMove = true;
            }
        }
    }

    IEnumerator Lose()
    {
        disablePlay = true;

        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene(sceneName);
    }
}
