using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyController : MonoBehaviour, IModelAnimationController
{

    [SerializeField]
    private ParticleSystem fireworks;

    private bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        Stop();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        isPlaying = true;
        fireworks.Play();

    }

    public void Stop()
    {
        isPlaying = false;
        fireworks.Stop();

    }

    public void ToggleAni()
    {
        if (isPlaying)
        {
            Stop();
        }
        else
        {
            Play();
        }

    }
}
