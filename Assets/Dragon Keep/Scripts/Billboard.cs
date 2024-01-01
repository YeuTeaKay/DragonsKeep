using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        GameObject mainCamera = GameObject.FindGameObjectWithTag("MainCamera");

        if (mainCamera != null)
        {
            transform.LookAt(mainCamera.transform);
        }
    }
}
