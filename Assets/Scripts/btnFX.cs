using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFX : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip ClickFx;
    public void Clicksound()
    {
        myFx.PlayOneShot(ClickFx);
    }
}
