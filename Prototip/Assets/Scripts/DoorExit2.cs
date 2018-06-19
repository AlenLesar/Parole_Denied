using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorExit2 : MonoBehaviour
{

    public GameObject OpenPanel = null;
    public GameObject Player = null;

    void Update()
    {
        int questions = Player.GetComponent<Playerscript>().tasks;

        if (questions == 7)
        {
            BoxCollider collider = GetComponent<BoxCollider>();
            collider.enabled = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(false);
        }
    }
}
