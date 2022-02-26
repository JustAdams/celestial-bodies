using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 25f;
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
        Vector3 movement = new Vector3(Input.GetAxisRaw("Horizontal"), verticalMovement, Input.GetAxis("Vertical")) * Time.deltaTime * movementSpeed;
        transform.Translate(movement, transform);
    }
}
