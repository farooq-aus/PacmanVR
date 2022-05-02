using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasd : MonoBehaviour
{
    public int Speed = 1;
    public float sensitivity = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float zAxisValue = Input.GetAxis("Horizontal") * Speed * -0.005f;
        float xAxisValue = Input.GetAxis("Vertical") * Speed * 0.005f;
        float yValue = 0.0f;

        if (Input.GetKey(KeyCode.Q))
        {
            yValue = -Speed;
        }
        if (Input.GetKey(KeyCode.E))
        {
            yValue = Speed;
        }

        transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y + yValue, transform.position.z + zAxisValue);
    }

    void FixedUpdate()
    {
        float rotateHorizontal = Input.GetAxis("Mouse X");
        float rotateVertical = Input.GetAxis("Mouse Y");
        //transform.RotateAround(transform.position, -Vector3.up, rotateHorizontal * sensitivity); //use 
        transform.Rotate(transform.up * rotateHorizontal * 5); //instead if you dont want the camera to rotate around the player
        //transform.RotateAround(Vector3.zero, transform.up, rotateVertical * sensitivity);
        transform.Rotate(-transform.forward * rotateVertical * 5);
    }
}
