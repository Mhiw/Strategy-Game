using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private Camera cam;
    private Vector3 dragOrigin;

    [Header("Values")]
    [SerializeField] private float zoomSpeed = 1f;
    [SerializeField] private float maxZoom = 10f;
    [SerializeField] private float minZoom = 1f;

    void Update()
    {
        PanCamera();
        ZoomCamera();
    }

    private void PanCamera()
    {
        if(Input.GetMouseButtonDown(0))
            dragOrigin = cam.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetMouseButton(0))
        {
            Vector3 difference = dragOrigin - cam.ScreenToWorldPoint(Input.mousePosition);
            transform.position += difference;
        }
    }

    private void ZoomCamera()
    {
        float zoomAmount = Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;
        float newZoom = cam.orthographicSize - zoomAmount;
        cam.orthographicSize = Mathf.Clamp(newZoom, minZoom, maxZoom);
    }
}
