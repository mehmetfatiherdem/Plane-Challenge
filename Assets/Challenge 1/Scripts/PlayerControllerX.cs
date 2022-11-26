﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    private float speed = 20.0f;
    private float rotationSpeed = 150.0f;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // plane was going backwards so we need to change it
        // multiply by deltaTime to the speed will be increased per second instead of per frame
        // also I give priority to scalar value rather than the vectoral since it is more efficient this way 
        transform.Translate(speed * Time.deltaTime * Vector3.forward);

        // tilt the plane up/down based on up/down arrow keys
        // multiply with the verticalInput
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * verticalInput);

    }
}
