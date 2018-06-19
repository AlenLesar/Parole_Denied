using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructionOne : MonoBehaviour
{
    public GameObject OpenPanel = null;
    public GameObject Player = null;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int cards = Player.GetComponent<Playerscript>().cards;

        if (cards == 3)
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
