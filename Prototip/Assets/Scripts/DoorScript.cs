using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorScript : MonoBehaviour
{

    private Animator _animator;

    public GameObject OpenPanel = null;

    private bool _isInsideTrigger = false;

    private bool isOpen = false;

    public AudioSource openDoorSound;
    public AudioSource closeDoorSound;

    public GameObject player;

    // Use this for initialization
    void Start()
    {
        _animator = this.transform.parent.GetComponent<Animator>();        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            UpdatePanelText();
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

  

    private void UpdatePanelText()
    {
        string OpenText = "Otvori 'E'";
        string CloseText = "Zatvori 'E'";
        Text panelText = OpenPanel.transform.Find("Text").GetComponent<Text>();
        if (panelText != null)
        {
            panelText.text = isOpen ? CloseText : OpenText;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player && player.GetComponent<Playerscript>().tasks == 10) 
        {
            GetComponent<BoxCollider>().enabled=true;
        }

        if (_isInsideTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                OpenPanel.SetActive(false);

                isOpen = _animator.GetBool("open");

                if (isOpen == true)
                {
                    _animator.SetBool("open", false);
                    _animator.SetBool("close", true);
                    closeDoorSound.Play();
                    
                }

                else if(isOpen == false)
                {
                    _animator.SetBool("close", false);
                    _animator.SetBool("open", true);
                    openDoorSound.Play();
                }

                isOpen = !isOpen;

               

            }
        }
    }
}
