using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour
{
    // Update is called once per frame
    public void load(string sceneToLoad)
    {
        if (sceneToLoad != null && sceneToLoad != "")
        { 
            //Debug.Log(sceneToLoad);
            ARSceneManager.Instance.loadscene(sceneToLoad);
            //_ARscenemanager.loadscene(sceneToLoad);
        }
    }
}
