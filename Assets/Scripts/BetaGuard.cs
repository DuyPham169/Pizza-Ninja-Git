using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BetaGuard : MonoBehaviour
{
    public int startingPos;
    public GameObject player; 
    public int turnRate;
    public int turnAngle;

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
        playerTurn = player.GetComponent<BetaMovement>().turn;
        if (guardTurn != (startingPos + playerTurn) && player.GetComponent<BetaMovement>().confirmedMove)
        {
            guardTurn = startingPos + playerTurn;
            if (guardTurn % turnRate == 0) 
            {
                transform.Rotate(new Vector3(0, 0, turnAngle));
            }
            else
            {
                transform.position += -transform.up;
            }
        }
    }
}
