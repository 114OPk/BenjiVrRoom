using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour
{
    public AudioSource bounceAudio;

    public void OnCollisionEnter(Collision collision)
    {
        bounceAudio.Play();
    }
}
