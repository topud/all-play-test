using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyController : MonoBehaviour
{

    [SerializeField]
    private ParticleSystem fireworks;

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
        fireworks.Play();

    }

    public void stop()
    {
        isPlaying = false;
        fireworks.Stop();

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
