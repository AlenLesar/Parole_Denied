using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

    public GameObject exitPanel = null;
    public Camera exitCamera = null;
    public Camera mainCamera = null;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            exitPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            exitPanel.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
