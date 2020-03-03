using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarracadeController : MonoBehaviour, IModelAnimationController
{

    [SerializeField]
    private GameObject lightFlairs;

    private bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        Stop();
    }

    public void Play()
    {
        isPlaying = true;
        lightFlairs.SetActive(isPlaying);
    }

    public void Stop()
    {
        isPlaying = false;
        lightFlairs.SetActive(isPlaying);
    }

    public void ToggleAni()
    {
        if(isPlaying)
        {
            Stop();
        } else
        {
            Play();
        }

    }
}
