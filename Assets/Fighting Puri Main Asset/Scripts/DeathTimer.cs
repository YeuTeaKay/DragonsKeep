using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DeathTimer : MonoBehaviour
{
    public GameObject targetObject;
    public TMP_Text destructionTimeText;

    private float startTime;
    private bool objectDestroyed = false;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (!objectDestroyed)
        {
            if (targetObject == null)
            {
                objectDestroyed = true;
            }
            else
            {
                float timeBeforeDestruction = Time.time - startTime;
                destructionTimeText.text = "Time: " + timeBeforeDestruction.ToString("F2");
            }
        }
    }
}
