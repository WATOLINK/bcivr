using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraEffects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Color underwaterColor = new Color (0.22f, 0.65f, 0.77f, 0.5f);
        RenderSettings.fog = true;
        RenderSettings.fogColor = underwaterColor;
        RenderSettings.fogDensity = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
