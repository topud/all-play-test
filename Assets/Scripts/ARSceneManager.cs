using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARSceneManager : MonoBehaviour
{
    private string lastActiveScene;

    public void loadscene(string sceneName)
    {
        //Camera.main.enabled = false;
        SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        lastActiveScene = sceneName;
        //ScreenManager.Instance.ARScreenMode();
    }

    public void unloadscene()
    {

        if (lastActiveScene != null && lastActiveScene != "")
            SceneManager.UnloadSceneAsync(lastActiveScene);
        //ScreenManager.Instance.UIScreenMode();
        //Camera.main.enabled = true;
    }
}
