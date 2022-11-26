using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    private float propellarRotationSpeed = 3000.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotate the propeller
        transform.Rotate(Vector3.forward, propellarRotationSpeed * Time.deltaTime);

    }
}
