using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePosition : MonoBehaviour
{
    Vector2 positionSave;
    void Start()
    {
        positionSave = transform.position;
    }

    
    public void LoadPosition()
    {
        transform.position = positionSave;
    }
}
