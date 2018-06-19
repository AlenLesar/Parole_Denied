using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[AddComponentMenu("Camera-Control/Mouse Look")]
public class MouseLook_sensitivity : MonoBehaviour {

    public float sensitivityXX = 0f;
    public float sensitivityYY = 0f;

    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    private float sensitivityX = 5f;
    private float sensitivityY = 5f;

    private float minimumX = 0f;
    private float maximumX = 360f;

    private float minimumY = -30f;
    private float maximumY = 45f;

    private float rotationY = 0f;

    void Update()
    {
        if (axes == RotationAxes.MouseXAndY)
        {
            float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityXX;

            rotationY += Input.GetAxis("Mouse Y") * sensitivityYY;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
        }
        else if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityXX, 0);
        }
        else
        {
            rotationY += Input.GetAxis("Mouse Y") * sensitivityYY;
            rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationY, transform.localEulerAngles.y, 0);
        }
    }

    void Start()
    {
        // Make the rigid body not change rotation
        if (GetComponent<Rigidbody>())
            GetComponent<Rigidbody>().freezeRotation = true;
    }
}
