using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BlackHole[] blackHoles = FindObjectsOfType<BlackHole>();
        foreach (BlackHole bh in blackHoles)
        {
            if(bh.gameObject!=this.gameObject)
            {
                Destroy(bh.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
