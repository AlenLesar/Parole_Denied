using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject player;
    // container dialogue, public so we can manipulate
    // canvas, dialogue box and text
    public GameObject dialogueBox;
    public Text dialogueText;

    public bool dialogueActive; // true when we enter interactable game object
    public bool talkingToGuard; // object that will interact, when we exit the trigger, we want to close dialoge box

    public string[] dialogueLines; // variable that is changing the dialogue lines when we press enter 
    public int currentLine; // allow us to stop and start a conversation on specific point

    // Use this for initialization
    void Start()
    {
        dialogueBox.SetActive(false); // set our dialogue box false because we want him to turn on when we enter trigger 
    }

    // Update is called once per frame
    void Update()
    {
        // set up functionality to go through the lines by pressing enter key dependend if dialogue is on or off and depended
        // on the object we are talking to and line of conversation
        if (dialogueActive && Input.GetKeyDown(KeyCode.Return))
        {
            currentLine++; // everytime we press enter key, we scroll through the lines

            if (currentLine >= dialogueLines.Length && talkingToGuard == true)
            {
                // shut off because we want everything to end when we get to 3
                dialogueActive = false;
                dialogueBox.SetActive(false);
                dialogueBox.SetActive(false);
            }
        }
        // shut off the box when we reach the last number in our array and reset lines to zero
        if (currentLine >= dialogueLines.Length)
        {
            dialogueBox.SetActive(false);
            dialogueBox.SetActive(false);
            currentLine = 0;
            player.GetComponent<PlayerController>().walkSpeed = 2;
            player.GetComponent<PlayerController>().runSpeed = 6;
            player.GetComponent<PlayerController>().strafeSpeed = 2;

        }
        // setting text to be equal to array of dialogue lines
        dialogueText.text = dialogueLines[currentLine];
    }
    // turning dialogues on and off on specific actions

    void OnTriggerEnter(Collider other)
    {


        
        if (other.gameObject.tag == "TargetTriggered")
        { // start dialogue with guard at line 0
            currentLine = 0;
            // its true because we want to start a conversation
            dialogueActive = true;
            talkingToGuard = true;
            dialogueBox.SetActive(true);

            player.GetComponent<PlayerController>().walkSpeed = 0;
            player.GetComponent<PlayerController>().runSpeed = 0;
            player.GetComponent<PlayerController>().strafeSpeed = 0;
        }
    }
    // just set booleans to false, when we are leaving the trigger box, we are reseting current lines to zero 
    void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
        talkingToGuard = false;
    }
}
