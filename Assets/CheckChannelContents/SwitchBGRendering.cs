using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBGRendering : MonoBehaviour
{
    public Camera mainCam;
    public RenderTexture rt;
    public Camera secondCam;
    
    // Update is called once per frame
    public void ToggleRendering()
    {
        if (mainCam.targetTexture)
        {
            mainCam.targetTexture = null;
            secondCam.gameObject.SetActive(false);
        }
        else
        {
            mainCam.targetTexture = rt;
            secondCam.gameObject.SetActive(true);
        }
    }
}
