using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    private float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move Y axis  
        var verticalMovement = (Input.GetKey(KeyCode.Space) ? 1 : 0) + (Input.GetKey(KeyCode.C) ? -1 : 0);
        // Move X and Z axis
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), verticalMovement, Input.GetAxis("Vertical"));
        transform.Translate(movement, transform);

        // Mouse look
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRotation -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        transform.parent.Rotate(Vector3.up * mouseX);
    }
}
