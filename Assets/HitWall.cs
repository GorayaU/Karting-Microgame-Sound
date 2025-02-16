using System;
using System.Collections;
using System.Collections.Generic;
using FMOD.Studio;
using Karting.Audio_Shit;
using UnityEngine;

public class HitWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioManager.Instance.PlayOneShot(FmodEvents.Instance.WallHit, transform.position);
        }
    }
}
