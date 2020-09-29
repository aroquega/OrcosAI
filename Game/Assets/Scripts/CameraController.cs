using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float panSpeed = 20.0f;
    public int padding = 10;

    void LateUpdate()
    {
        Vector3 newPosition = this.transform.position;

        if (Input.mousePosition.y < padding)
        {
            newPosition.z -= panSpeed * Time.deltaTime;
        }
        else if (Input.mousePosition.y > Screen.height - padding)
        {
            newPosition.z += panSpeed * Time.deltaTime;
        }

        if (Input.mousePosition.x < padding)
        {
            newPosition.x -= panSpeed * Time.deltaTime;
        }
        else if (Input.mousePosition.x > Screen.width - padding)
        {
            newPosition.x += panSpeed * Time.deltaTime;
        }

        this.transform.position = newPosition;
    }
}
