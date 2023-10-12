using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consume : MonoBehaviour
{
    public GameObject consumable;
    public LayerMask playerLayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y), .4f, playerLayer))
        {
            consumable.SetActive(false);
        }
    }
}
