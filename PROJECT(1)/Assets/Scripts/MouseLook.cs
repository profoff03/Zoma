using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    [SerializeField] private float mouseSensetivity = 100f;

    [SerializeField] private Transform playerBody;

    private float XRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensetivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensetivity * Time.deltaTime;


        XRotation -= mouseY;
        XRotation = Mathf.Clamp(XRotation,-90f, 90f);
        
        transform.localRotation = Quaternion.Euler(XRotation,0f,0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
