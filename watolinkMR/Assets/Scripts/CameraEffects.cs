using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraEffects : MonoBehaviour
{
    public float fogDensity = 0.1f;
    public Color waterColor = new Color (0.22f, 0.65f, 0.77f, 0.5f);
    // Start is called before the first frame update
    void Start()
    {
        RenderSettings.fog = true;
        RenderSettings.fogColor = waterColor;
        RenderSettings.fogDensity = fogDensity;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
