using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float explosionForce, explosionRadius;
    public LayerMask effectedObjects;

    void Start()
    {
        Invoke("DestroyGO", 0.5f);
    }

    void FixedUpdate()
    {
        ThrowObjectsAway(DetectObjectsInRange());
    }

    Collider2D[] DetectObjectsInRange()
    {
        return Physics2D.OverlapCircleAll(transform.position, explosionRadius, effectedObjects);
    }

    void ThrowObjectsAway(Collider2D[] objectsInRange)
    {
        foreach (Collider2D objectCollider in objectsInRange)
        {
            Vector2 directionToMove = transform.position - objectCollider.transform.position;
            objectCollider.GetComponent<Rigidbody2D>().AddForce(-directionToMove * explosionForce);
        }
    }

    void DestroyGO()
    {
        Destroy(this.gameObject);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, explosionRadius);
    }
}
