using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void FixedUpdate() 
    {
        float x = Input.GetAxisRaw("Horizontal") * 2.0f;
        float z = Input.GetAxisRaw("Vertical") * 3.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        
    }
}
