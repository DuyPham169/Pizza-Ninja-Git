using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string SceneName;
    public LayerMask player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y), .4f, player))
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
