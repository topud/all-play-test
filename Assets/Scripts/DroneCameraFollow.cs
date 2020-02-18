using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneCameraFollow : MonoBehaviour
{
    public GameObject ARCamera;
    public float delay = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var rotation = Quaternion.LookRotation(ARCamera.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * delay);

        //Move drone to camera, not working yet
        //Vector3 newTargetPos = ARCamera.transform.position;
        //newTargetPos.z = transform.position.z;
        //newTargetPos.x = transform.position.x;

        //transform.position = newTargetPos ;
    }
}
