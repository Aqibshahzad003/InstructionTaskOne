using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float HorizontalInput;

    public float TurnSpeed;
    // Update is called once per frame
    void Update()
    {
        if(UIScript.IsGameStarted==true)
        {
            HorizontalInput = Input.GetAxis("Horizontal");

            transform.Rotate(Vector3.up, TurnSpeed * HorizontalInput * Time.deltaTime);
        }
    }
}
