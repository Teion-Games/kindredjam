using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float horizontalMove {get {return _horizontalMove;} set  {_horizontalMove = value;} }
    public float verticalMove {get {return _verticalMove;} set  {_verticalMove = value;} }

    
    float _horizontalMove;
    float _verticalMove;

    PlayerInputActions inputActions;
    
    void Start()
    {
        inputActions = new PlayerInputActions();
        if(CheckPlayer())  
        {
            inputActions.Player.Enable();
            inputActions.GameMisc.Enable();
        }
        else 
        {
            inputActions.Player2.Enable();
        }
    }

    void Update()
    {
        if(FindObjectOfType<DialogueManager>().dialogIsOn)
        {
            _horizontalMove = 0f;
            _verticalMove = 0f;
            if(inputActions.GameMisc.DialoguePass.triggered)
            {
                Debug.Log("triggered");
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
            }
        }
        else
        {
             if(CheckPlayer())
            {
                GetPlayer1Inputs();
            }
            else
            {
                GetPlayer2Inputs();
            }
        } 
    }

    void GetPlayer1Inputs()
    {
        GetPlayer1MovmentInput();
        if(inputActions.Player.Power.triggered) 
        {
            GetComponent<PlayerPower>().UsePower();
        }
        if(inputActions.Player.SecundaryPower.triggered) 
        {
            GetComponent<PlayerPower>().UseSecundaryPower();
        }
    }

    void GetPlayer2Inputs()
    {
        GetPlayer2MovmentInput();

        if(inputActions.Player2.Power.triggered)
        {
            GetComponent<PlayerPower>().UsePower();
        }

        if(inputActions.Player2.ReleasePower.triggered)
        {
            GetComponent<PlayerPower>().DestroyFirstPower();
        }

        if(inputActions.Player2.SecundaryPower.triggered) 
        {
            GetComponent<PlayerPower>().UseSecundaryPower();
        }
    }

    void GetPlayer1MovmentInput()
    {
        _horizontalMove = inputActions.Player.Horizontal.ReadValue<float>();
        if(_horizontalMove == 0)
        {
            _verticalMove = inputActions.Player.Vertical.ReadValue<float>();
        }
        else
        {
            _verticalMove = 0f;
        }
    }

    void GetPlayer2MovmentInput()
    {
        _horizontalMove = inputActions.Player2.Horizontal.ReadValue<float>();
        if(_horizontalMove == 0)
        {
            _verticalMove = inputActions.Player2.Vertical.ReadValue<float>();
        }
        else
        {
            _verticalMove = 0f;
        }
    }

    bool CheckPlayer()
    {
        if(gameObject.name == "Ein")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
