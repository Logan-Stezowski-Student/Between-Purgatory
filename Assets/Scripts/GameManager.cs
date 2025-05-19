using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
   public static GameManager instance;

    private void Awake()
    {
        if (instance) 
        {
            Destroy(this);
        }
        else 
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }
    public static void LoadScene (string newSceneName) 
    {
        SceneManager.LoadScene(newSceneName);
    }

    public static void Quit() 
    {
        Application.Quit();
    }
}
