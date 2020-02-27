using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderController : MonoBehaviour
{

    [SerializeField]
    private Animator signAnimator;

    private bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        stop();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void play()
    {
        isPlaying = true;
        signAnimator.SetBool("play", isPlaying);
    }

    public void stop()
    {
        isPlaying = false;
        signAnimator.SetBool("play", isPlaying);
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
