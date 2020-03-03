using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ModelAnimatorController : MonoBehaviour, IModelAnimationController

{

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private bool playOnStart = false;

    private bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        if (playOnStart)
        {
            Play();
        }
        else
        {
            Stop();
        }

    }

    public void Play()
    {
        isPlaying = true;
        animator.SetBool("play", isPlaying);
    }

    public void Stop()
    {
        isPlaying = false;
        animator.SetBool("play", isPlaying);
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
