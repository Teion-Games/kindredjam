using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneLoading : MonoBehaviour
{
    Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void StartAnimation()
    {
        anim.SetTrigger("start");
    }

}
