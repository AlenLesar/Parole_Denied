using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_book : MonoBehaviour {

    public GameObject OpenPanel = null;

    private bool _isInsideTrigger = false;

    public GameObject player;


    // Use this for initialization
    void Start () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {    
           _isInsideTrigger = true;
            OpenPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(false);
           _isInsideTrigger = false;
        }
    }

    // Update is called once per frame
    void Update () {
     
        if (_isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OpenPanel.SetActive(false);
                player.GetComponent<Playerscript>().cards++;
                Destroy(gameObject);

            }
        }
        
    }
}
