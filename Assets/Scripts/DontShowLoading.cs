using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class DontShowLoading : MonoBehaviour
{
    bool firstLoadingPassed;
    #region Singleton
    public static DontShowLoading instance;
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
            foreach (sceneLoading sceneLoading in FindObjectsOfType<sceneLoading>())
            {
                if(sceneLoading.gameObject.name == "Loading")
                {
                    Debug.Log("startando loading");
                    sceneLoading.StartAnimation();
                }
            }
        }
        else
        {
            Destroy(gameObject);
            foreach (sceneLoading sceneLoading in FindObjectsOfType<sceneLoading>())
            {
                if (sceneLoading.gameObject.name=="fadeIn")
                {
                    Debug.Log("startando fadein");
                    sceneLoading.StartAnimation();
                }
            }
        }

    }
    #endregion


    // Update is called once per frame
    public void DestroyDontShowLoading()
    {
        Destroy(instance);
        Destroy(this.gameObject);
    }
}
