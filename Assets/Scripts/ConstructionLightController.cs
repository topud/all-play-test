using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ConstructionLightController : MonoBehaviour
{
    [SerializeField]
    private GameObject arCamera;

    [SerializeField]
    private GameObject lightNeck;

    [SerializeField]
    private GameObject lightLamp;

    [SerializeField]
    private GameObject lightFlair;

    [SerializeField]
    private float delay = 1.0f;

    [SerializeField]
    private bool playOnStart = false;

    private bool isPlaying = false;

    private Vector3 neckOffRot;
    private Vector3 lampOffRot;

    // Start is called before the first frame update
    void Start()
    {
        //neckOffRot = lightNeck.transform.localRotation.eulerAngles;
        //lampOffRot = lightLamp.transform.localRotation.eulerAngles;

        if (playOnStart)
        {
            play();
        } else
		{
            stop();
		}

    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            // Look at something... camera, dialog etc.
        }
    }

    public void play()
    {
        isPlaying = true;
        lightFlair.SetActive(isPlaying);
    }

    public void stop()
    {
        isPlaying = false;

        lightFlair.SetActive(isPlaying);
        //lightNeck.transform.DORotate(neckOffRot, 1.0f);
        //lightLamp.transform.DORotate(lampOffRot, 1.0f);
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
