using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consume : MonoBehaviour
{
    public GameObject consumable;
    public GameObject exit;
    public LayerMask playerLayer;
    public AudioSource ding;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y), .4f, playerLayer))
        {
            exit.GetComponent<Exit>().collected += 1;
            ding.Play();
            consumable.SetActive(false);
        }
    }
}
