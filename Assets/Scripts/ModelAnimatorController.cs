using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ModelAnimatorController : MonoBehaviour

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
            play();
        }
        else
        {
            stop();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void play()
    {
        isPlaying = true;
        animator.SetBool("play", isPlaying);
    }

    public void stop()
    {
        isPlaying = false;
        animator.SetBool("play", isPlaying);
    }

    public void toggleAni()
    {
        if (isPlaying)
        {
            stop();
        }
        else
        {
            play();
        }

    }
}
