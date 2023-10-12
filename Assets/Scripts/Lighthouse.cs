using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lighthouse : MonoBehaviour
{
    public GameObject player;

    private int playerTurn;
    private int oldTurn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerTurn = player.GetComponent<PlayerMovement>().turn;
        if ((playerTurn % 2 == 0) && (playerTurn != 0) && (playerTurn != oldTurn))
        {
            transform.Rotate(new Vector3(0, 0, -90));
            oldTurn = playerTurn;
        }
    }
}
