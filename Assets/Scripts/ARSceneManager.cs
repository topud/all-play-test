using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARSceneManager : MonoBehaviour
{
    //Keeps track of the last scene we loaded so we can unload the scene later
    private string lastActiveScene;
    public static ARSceneManager Instance { get; private set; }

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    

    //Accepts a string as scene name which is the path for the scene, for example "Scenes/Construction-Digital"
    public void loadscene(string sceneName)
    {
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        lastActiveScene = sceneName;
    }

    //Check that we actually have a scene loaded and then unloads it.
    public void unloadscene()
    {
        if (lastActiveScene != null && lastActiveScene != "")
            SceneManager.UnloadSceneAsync(lastActiveScene);
    }
}
