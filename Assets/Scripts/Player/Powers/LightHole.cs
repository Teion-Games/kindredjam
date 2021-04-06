using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHole : MonoBehaviour
{
     void Start()
    {
        LightHole[] lightHoles = FindObjectsOfType<LightHole>();
        foreach (LightHole lh in lightHoles)
        {
            if(lh.gameObject!=this.gameObject)
            {
                Destroy(lh.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
