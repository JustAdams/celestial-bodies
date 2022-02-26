using TMPro;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public Camera mainCamera;
    public CelestialBody selectedObject;
    public TextMeshProUGUI planetInfo;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Select a celestial body on left mouse
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                selectedObject = hit.transform.GetComponent<CelestialBody>();

                if (selectedObject != null)
                {
                    planetInfo.gameObject.SetActive(true);
                    planetInfo.text = selectedObject.name;
                }
            }
            else
            {
                selectedObject = null;
                planetInfo.gameObject.SetActive(false);
                planetInfo.text = "";
            }
        }

    }
}
