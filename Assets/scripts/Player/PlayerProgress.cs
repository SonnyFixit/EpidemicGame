using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgress : MonoBehaviour
{
    [SerializeField]
    public static int progress = 0;

    public void levelUp()
    {
        progress++;
        Debug.Log(progress);
    }
}
