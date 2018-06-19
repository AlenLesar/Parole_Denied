using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tasks_script : MonoBehaviour
{

    public GameObject OpenPanel = null;
    public GameObject TaskPanel = null;
    public GameObject TaskCamera = null;

    private bool _isInsideTrigger = false;


    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && OpenPanel && TaskPanel && TaskCamera)
        {
            _isInsideTrigger = true;
            OpenPanel.SetActive(true);

        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && OpenPanel && TaskPanel && TaskCamera)
        {
            OpenPanel.SetActive(false);
            TaskPanel.SetActive(false);
            _isInsideTrigger = false;
            TaskCamera.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
    }
        
    }


    // Update is called once per frame
    void Update()
    {

        if (_isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                OpenPanel.SetActive(false);
                TaskPanel.SetActive(true);
                TaskCamera.SetActive(true);
             // MainCamera.SetActive(false);
 
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        } 
      

        if (Input.GetKeyDown("1"))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            
        }

        if (Input.GetKeyDown("2"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            
        }
    }
}