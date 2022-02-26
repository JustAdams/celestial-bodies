using UnityEngine;

public class CursorController : MonoBehaviour
{
    public Camera mainCamera;
    public CelestialBody selectedObject;

    // Update is called once per frame
    void Update()
    {
        // Select a celestial body on left mouse, clear selection on right mouse
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                selectedObject = hit.transform.GetComponent<CelestialBody>();
            }
        } 
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            selectedObject = null;
        }
    }
}
