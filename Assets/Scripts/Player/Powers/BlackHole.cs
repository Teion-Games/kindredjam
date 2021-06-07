using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHole : MonoBehaviour
{
    public float suckRange;
    public LayerMask suckableObjects;
    public float suckSpeed;
    public bool isBlackHole;

    // Update is called once per frame
    void Update()
    {
        BlackHoleBehaviour();
    }

    void BlackHoleBehaviour()
    {
        SuckObjects(DetectObjectsInRange());
    }

    public Collider2D[] DetectObjectsInRange()
    {
        return Physics2D.OverlapCircleAll(transform.position, suckRange, suckableObjects);
    }

    void SuckObjects(Collider2D[] objectsInRange)
    {
        foreach (Collider2D objectCollider in objectsInRange)
        {
            if(objectCollider.gameObject.tag=="Player1" && isBlackHole)
            {
                FindObjectOfType<KillPlayer>().KillThePlayer(objectCollider.gameObject);
            }
            Vector2 directionToMove = transform.position - objectCollider.transform.position;
            if(Mathf.Abs(directionToMove.x)>Mathf.Abs(directionToMove.y) && Mathf.Abs(directionToMove.x)>0.1f)
            {
                objectCollider.GetComponent<Rigidbody2D>().velocity = new Vector2(directionToMove.x, 0f) * suckSpeed;
            }
            else if (Mathf.Abs(directionToMove.y)>Mathf.Abs(directionToMove.x)  && Mathf.Abs(directionToMove.y)>0.1f)
            {
                objectCollider.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, directionToMove.y) * suckSpeed;
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
