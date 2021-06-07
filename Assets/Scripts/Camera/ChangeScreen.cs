using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeScreen : MonoBehaviour
{
    [SerializeField]  CinemachineBrain p1Cam, p2Cam, bothCam;
    [SerializeField] Animator p1CanvasAnim, p2CanvasAnim, bothCanvasAnim;
    [SerializeField] float checkRange;
    [SerializeField] LayerMask p2CamLayermask;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 7 && !FindObjectOfType<Sincronia>().isInSync)
        {
            JuntarTelas();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 7 && !FindObjectOfType<Sincronia>().isInSync)
        {
            SepararTelas();
        }
    }

    void JuntarTelas()
    {
        p1CanvasAnim.SetTrigger("juntar");
        p2CanvasAnim.SetTrigger("juntar");
        Invoke("AtivarCameraConjunta", 0.16f);
    }
    
    void AtivarCameraConjunta()
    {
        p1Cam.gameObject.SetActive(false);
        p2Cam.gameObject.SetActive(false);
        bothCam.gameObject.SetActive(true);
    }

    void SepararTelas()
    {
        Separar();
        p1CanvasAnim.SetTrigger("separar");
        p2CanvasAnim.SetTrigger("separar");
    }

    public void Separar()
    {
        p1Cam.gameObject.SetActive(true);
        p2Cam.gameObject.SetActive(true);
        bothCam.gameObject.SetActive(false);
    }

    public void ForceCheckCamera()
    {
        Collider2D[] detectedObjectsInRange = Physics2D.OverlapCircleAll(transform.position, checkRange, p2CamLayermask);
        if(detectedObjectsInRange.Length>0)
        {
            AtivarCameraConjunta();
            Debug.Log("conjunta");
        }
        else
        {
            Debug.Log("separada");
            Separar();
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, checkRange);
    }
}
