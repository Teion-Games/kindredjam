using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSFX : MonoBehaviour
{
    public AudioSource option;
    public AudioSource selected;

    public void PlayOption()
    {
        option.Play();
    }

    public void PlaySelected()
    {
        selected.Play();
    }
}
