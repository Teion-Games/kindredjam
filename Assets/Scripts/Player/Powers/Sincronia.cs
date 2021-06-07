using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sincronia : MonoBehaviour
{
    [SerializeField] int numberOfUsages;
    [SerializeField] float syncDuration;
    Transform player1Transform, player2Transform;
    public bool isInSync = false;
    bool _p1Sync, _p2Sync;
    public bool p1Sync {get {return _p1Sync;} set  {_p1Sync = value;} }
    public bool p2Sync {get {return _p2Sync;} set  {_p2Sync = value;} }
    Vector3 savePosition;
    
    #region Singleton
    public static Sincronia instance;
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

    void Start()
    {
        PlayerInput[] players = FindObjectsOfType<PlayerInput>();
            foreach (PlayerInput player in players)
            {
                if(player.gameObject.name == "Ein")
                {
                    player1Transform = player.transform;
                }
                else
                {
                    player2Transform = player.transform;
                }
            }
    }

    // Update is called once per frame
    void Update()
    {
        if(_p1Sync && _p2Sync && numberOfUsages>0 && !isInSync)
        {
            numberOfUsages--;
            ResetSyncVariables();
            ChangePositions();
        }
    }

    void ResetSyncVariables()
    {
        _p1Sync = false;
        _p2Sync = false;  
    }

    void ChangePositions()
    {
        isInSync = true;
        savePosition = player1Transform.position;
        player1Transform.position = player2Transform.position;
        player2Transform.position = savePosition;
        FindObjectOfType<ChangeScreen>().Separar();
        Invoke("UndoChangedPositions", syncDuration);
    }

    void UndoChangedPositions()
    {
        isInSync = false;
        savePosition = player1Transform.position;
        player1Transform.position = player2Transform.position;
        player2Transform.position = savePosition;
        Invoke("Teste", 0.32f);
    }

    void Teste()
    {
        FindObjectOfType<ChangeScreen>().ForceCheckCamera();
    }
    public void CancelChangePositions()
    {
        CancelInvoke();
    }
}
