using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraClass : MonoBehaviour
{
    public static WebCamTexture cameraTexture;
    public static bool isPaused;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        cameraTexture = new WebCamTexture();
        rend = GetComponent<Renderer>();
        rend.material.mainTexture = cameraTexture;
        cameraTexture.Play();
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
