using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SpawnParticleInTiles : MonoBehaviour
{
    
    Tilemap tilemap;
    public GameObject particleEffect;

    void Start()
    {
        tilemap = GetComponent<Tilemap>();

        BoundsInt bounds = tilemap.cellBounds;
        TileBase[] allTiles = tilemap.GetTilesBlock(bounds);
         
        for (int x = 0; x < bounds.size.x; x++) {
            for (int y = 0; y < bounds.size.y; y++) {
                TileBase tile = allTiles[x + y * bounds.size.x];
                if (tile != null) {
                    Instantiate(particleEffect, tilemap.CellToWorld(new Vector3Int(x,y,0)), Quaternion.identity);
                } 
            }
        }        
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
