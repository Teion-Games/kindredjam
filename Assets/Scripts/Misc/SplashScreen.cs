using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public GameObject transition;

    void Start()
    {
        StartCoroutine(Wait());       
    }

    IEnumerator Wait(){
        yield return new WaitForSeconds(5f);

        transition.SetActive(true);
    }
}
