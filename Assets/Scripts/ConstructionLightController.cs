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

    private Vector3 neckStartRot;
    private Vector3 lampStartRot;
    // account for the containing models -90 rotation offset
    private Vector3 rotOffset = new Vector3(-90, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        neckStartRot = lightNeck.transform.localRotation.eulerAngles + rotOffset;
        lampStartRot = lightLamp.transform.localRotation.eulerAngles + rotOffset;

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
            // We only want to rotate the Y axis for the light's "neck" object, and account for the light x rotation offset
            var lightNeckLookRot = Quaternion.Euler(rotOffset.x, getLookRot(lightNeck).eulerAngles.y, 0);
            lightNeck.transform.rotation = getSlerpToRot(lightNeck, lightNeckLookRot);

            // We only want to rotate the X axis for the light's "lamp" object, taking into account the light's neck rotation and x rotation offset
            var lampLookRot = Quaternion.Euler(getLookRot(lightLamp).eulerAngles.x + rotOffset.x, lightNeck.transform.rotation.eulerAngles.y, 0);
            lightLamp.transform.rotation = getSlerpToRot(lightLamp, lampLookRot);
        }
    }

    Quaternion getLookRot(GameObject obj)
    {
        return Quaternion.LookRotation(arCamera.transform.position - obj.transform.position);
    }

    Quaternion getSlerpToRot(GameObject obj, Quaternion lookRot)
    {
        return Quaternion.Slerp(obj.transform.rotation, lookRot, delay * Time.deltaTime);
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


        lightNeck.transform.DORotate(neckStartRot, 1.0f);
        lightLamp.transform.DORotate(lampStartRot, 1.0f);
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
