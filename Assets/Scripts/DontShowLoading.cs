using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontShowLoading : MonoBehaviour
{
    bool isFirstLoading = true;
    public GameObject loadingScreen, fadeInScreen;
    #region Singleton
    public static DontShowLoading instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }

        if(isFirstLoading)
        {
            loadingScreen.SetActive(true);
        }
        else
        {
            fadeInScreen.SetActive(true);
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
