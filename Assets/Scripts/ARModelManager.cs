using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARModelManager : MonoBehaviour
{

    private GameObject[] modelPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        if(modelPrefabs == null)
        {
            modelPrefabs = GameObject.FindGameObjectsWithTag("ModelPrefab");
        }

        StopALLModelAnimations();

        PlayModelAnimation("Loader");
    }

    private void playPrefabAni(GameObject prefab)
    {
        var ctrl = prefab.GetComponent<IModelAnimationController>();

        if (ctrl != null)
        {
            ctrl.Play();
        }
    }


    public void PlayModelAnimation(string prefabName)
    {
        StopALLModelAnimations();

        foreach(GameObject prefab in modelPrefabs)
        {
            Debug.Log(prefab.name);
            Debug.Log(prefab.name == prefabName);
            if (prefab.name == prefabName)
            {
                playPrefabAni(prefab);
            }
            // Handling a special case where we need to play two sepatately controlled models
            else if(prefabName == "BarricadeAndSign")
            {
                if (prefab.name == "Barricade" || prefab.name == "Sign")
                {
                    playPrefabAni(prefab);
                }
            }
        }
    }

    public void StopALLModelAnimations()
    {
        foreach(GameObject prefab in modelPrefabs)
        {
            var ctrl = prefab.GetComponent<IModelAnimationController>();

            if(ctrl != null)
            {
                ctrl.Stop();
            }
        }
    }
}
