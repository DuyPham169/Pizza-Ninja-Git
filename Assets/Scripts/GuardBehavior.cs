using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GuardBehavior : MonoBehaviour
{
    public int startingPos;
    public GameObject player; 
    public int turnRate;
    public int yDirection;
    public int xDirection;

    private int guardTurn;
    private int playerTurn;
    // Start is called before the first frame update
    void Start()
    {
        guardTurn = startingPos;
    }

    // Update is called once per frame
    void Update()
    {
        playerTurn = player.GetComponent<PlayerMovement>().turn;
        if (guardTurn != (startingPos + playerTurn))
        {
            guardTurn = startingPos + playerTurn;
            if (guardTurn % turnRate == 0) 
            {
                transform.Rotate(new Vector3(180, 0, 0));
                yDirection = -yDirection;
            }
            else
            {
                transform.position += new Vector3(xDirection, yDirection, 0);
            }
        }
    }
}
