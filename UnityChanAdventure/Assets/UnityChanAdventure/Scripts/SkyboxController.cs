using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController : MonoBehaviour
{
    [SerializeField] private Material daySkybox;
    [SerializeField] private Material nightSkybox;
    [SerializeField] private Light sun;

    public void ChangeSkybox()
    {
        if (RenderSettings.skybox == daySkybox)
        {
            RenderSettings.skybox = nightSkybox;
            sun.intensity = 0.1f;
        }
        else
        {
            RenderSettings.skybox = daySkybox;
            sun.intensity = 1.0f;
        }
    }
}