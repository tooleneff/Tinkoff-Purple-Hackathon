using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.XR.CoreUtils;
using UnityEngine.XR.ARFoundation;
using Unity.VisualScripting;


[RequireComponent(typeof(XROrigin))]
public class CameraRotationManager : MonoBehaviour
{
    [SerializeField]
    GameObject m_CloudCity;
    
    [SerializeField]
    ARSession m_Session;
   
    public GameObject cloudCity
    {
        get => m_CloudCity;
        set => m_CloudCity = value;
    }


    private void OnEnable()
    {
        Application.onBeforeRender += Application_onBeforeRender;
    }

    private void OnDisable()
    {
        Application.onBeforeRender -= Application_onBeforeRender;
    }

    private void Application_onBeforeRender()
    {
        var camera = GetComponent<XROrigin>().Camera;
        if (camera && cloudCity)
        {
            cloudCity.transform.position = camera.transform.position + camera.transform.forward;
        }
    }

    private void Reset()
    {
        if (m_Session == null)
        {
            m_Session = FindObjectOfType<ARSession>();
        }
    }

}
