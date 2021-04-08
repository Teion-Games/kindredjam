using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHole : MonoBehaviour
{
    public float effectRange;
    public LayerMask suckableObjects;
    public float spitSpeed;

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
      WhiteHoleBehaviour();
    }

    void WhiteHoleBehaviour()
    {
        ThrowObjectsAway(DetectObjectsInRange());
    }

    Collider2D[] DetectObjectsInRange()
    {
        return Physics2D.OverlapCircleAll(transform.position, effectRange, suckableObjects);
    }

    void ThrowObjectsAway(Collider2D[] objectsInRange)
    {
        foreach (Collider2D objectCollider in objectsInRange)
        {
            Vector2 directionToMove = transform.position - objectCollider.transform.position;
            if(Vector2.Distance(transform.position, objectCollider.transform.position)<effectRange)
            {
                objectCollider.GetComponent<Rigidbody2D>().velocity = -directionToMove.normalized * spitSpeed;
            }
            else
            {
                objectCollider.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, effectRange);
    }
}
