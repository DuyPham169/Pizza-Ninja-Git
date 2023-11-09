using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public int collected;
    public int goal;
    public GameObject openExit;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collected == goal)
        {
            openExit.SetActive(true);
        }
    }
}
