using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public float suckRange;
    public LayerMask suckableObjects;
    public float suckSpeed;

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
        BlackHoleBehaviour();
    }

    void BlackHoleBehaviour()
    {
        SuckObjects(DetectObjectsInRange());
    }

    Collider2D[] DetectObjectsInRange()
    {
        return Physics2D.OverlapCircleAll(transform.position, suckRange, suckableObjects);
    }

    void SuckObjects(Collider2D[] objectsInRange)
    {
        foreach (Collider2D objectCollider in objectsInRange)
        {
            Vector2 directionToMove = transform.position - objectCollider.transform.position;
            if(Mathf.Abs(directionToMove.x)>0.1f||Mathf.Abs(directionToMove.y)>0.1f)
            {
                objectCollider.GetComponent<Rigidbody2D>().velocity = directionToMove.normalized * suckSpeed;
            }
            else
            {
                objectCollider.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, suckRange);
    }
}
