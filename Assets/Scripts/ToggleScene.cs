using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToggleScene : MonoBehaviour
{
    public string prevScene;
    public string nextScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene(prevScene);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
