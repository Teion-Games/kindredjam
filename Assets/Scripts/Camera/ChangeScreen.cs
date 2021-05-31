using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeScreen : MonoBehaviour
{
    [SerializeField]  CinemachineBrain p1Cam, p2Cam, bothCam;
    bool isSplit = true;
    [SerializeField] Animator p1CanvasAnim, p2CanvasAnim, bothCanvasAnim;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.layer == 7)
        {
            ChangeScreens();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.layer == 7)
        {
            ChangeScreens();
        }
    }

    void ChangeScreens()
    {
        if(isSplit)
        {
            // p1Cam.gameObject.SetActive(false);
            // p2Cam.gameObject.SetActive(false);
            // bothCam.gameObject.SetActive(true);
            p1CanvasAnim.SetTrigger("juntar");
            p2CanvasAnim.SetTrigger("juntar");
            Invoke("Juntar", 0.16f);
            isSplit = !isSplit;
        }
        else
        {
            p1Cam.gameObject.SetActive(true);
            p2Cam.gameObject.SetActive(true);
            bothCam.gameObject.SetActive(false);
            p1CanvasAnim.SetTrigger("separar");
            p2CanvasAnim.SetTrigger("separar");
            isSplit = !isSplit;
        }
    }

    void Juntar()
    {
        p1Cam.gameObject.SetActive(false);
        p2Cam.gameObject.SetActive(false);
        bothCam.gameObject.SetActive(true);
    }
}
