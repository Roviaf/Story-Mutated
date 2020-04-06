using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomOut;
    [SerializeField] float zoomIn;
    [SerializeField] float mouseSpeedOut;
    [SerializeField] float mouseSpeedIn;
    public bool zoombool;

    private void OnDisable()
    {
        ZoomOut();
    }

    private void Update(){Zooms();}


    void Zooms()
    {
        if (zoombool == true) { if (Input.GetButtonDown("Fire2")) { ZoomOut(); return;}}
        if (zoombool == false) { if (Input.GetButtonDown("Fire2")) { ZoomIn(); return;}}
    }

    void ZoomOut()
    {
        fpsController.mouseLook.XSensitivity = mouseSpeedOut;
        fpsController.mouseLook.YSensitivity = mouseSpeedOut;
        Camera.main.fieldOfView = zoomOut; zoombool = false; 
    }
    void ZoomIn()
    {
        fpsController.mouseLook.XSensitivity = mouseSpeedIn;
        fpsController.mouseLook.YSensitivity = mouseSpeedIn;
        Camera.main.fieldOfView = zoomIn; zoombool = true; 
    }
}
