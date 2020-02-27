using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarracadeController : MonoBehaviour
{

    [SerializeField]
    private GameObject lightFlairs;

    // More Animation TBD
    //[SerializeField]
    //private GameObject lightFlair01;

    //[SerializeField]
    //private GameObject lightFlair02;


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
        lightFlairs.SetActive(isPlaying);
    }

    public void stop()
    {
        isPlaying = false;
        lightFlairs.SetActive(isPlaying);
    }

    public void toggleAni()
    {
        if(isPlaying)
        {
            stop();
        } else
        {
            play();
        }

    }
}
