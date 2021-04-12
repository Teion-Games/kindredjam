using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    #region Singleton
    public static GameMaster instance;
    void Awake()
    {
    if (instance == null)
    {
    instance = this;
    }
    else
    {
    Destroy(gameObject);
    }
    }
    #endregion
    public GameObject fadeScreen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
