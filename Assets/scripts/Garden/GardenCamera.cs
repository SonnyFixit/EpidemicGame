using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GardenCamera : MonoBehaviour
{
  
    public Transform followTransform;


    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = new Vector3(followTransform.position.x, followTransform.position.y + 2.5f, this.transform.position.z);
    }
}
