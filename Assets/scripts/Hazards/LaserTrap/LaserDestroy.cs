using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDestroy : MonoBehaviour
{
    [SerializeField]
    private float timeTillDestroy;


    private void Update()

    {
        //Niszczy obiekt po podanym w inspektorze czasie
        Destroy(gameObject, timeTillDestroy);

    }
}
