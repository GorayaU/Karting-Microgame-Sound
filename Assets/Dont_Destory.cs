using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dont_Destory : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
