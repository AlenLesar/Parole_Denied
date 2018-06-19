using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScriptC : MonoBehaviour
{

    public GameObject TextBox;
    public GameObject Choice01;
    public GameObject Choice02;
    public GameObject Choice03;
    public GameObject Choice04;
    public int ChoiceMade;

    public GameObject closed_door = null;
    BoxCollider doorCollider;

    public GameObject player = null;
    CapsuleCollider player_collider;

    public GameObject second_door_instruction = null;
    BoxCollider secondDoorCollider = null;


    public void Option01()
    {
        TextBox.GetComponent<Text>().text = "Odgovor A je netočan!";
        ChoiceMade = 1;

        player_collider = player.GetComponent<CapsuleCollider>();
        if (player_collider.tag == "Player")
        {
            player_collider.GetComponent<Playerscript>().points -= 3;
        }
    }

    public void Option02()
    {
        TextBox.GetComponent<Text>().text = "Odgovor B je netočan!";
        ChoiceMade = 2;

        player_collider = player.GetComponent<CapsuleCollider>();
        if (player_collider.tag == "Player")
        {
            player_collider.GetComponent<Playerscript>().points -= 3;
        }
    }

    public void Option03()
    {
        TextBox.GetComponent<Text>().text = "Točan odgovor!";
        ChoiceMade = 3;

        player_collider = player.GetComponent<CapsuleCollider>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (second_door_instruction)
        {
            secondDoorCollider = second_door_instruction.GetComponent<BoxCollider>();
            secondDoorCollider.enabled = false;
        }

        if (closed_door) { 
        doorCollider = closed_door.GetComponent<BoxCollider>();
        doorCollider.enabled = true;
        }
      
        if(player_collider.tag=="Player")
        {
            player_collider.GetComponent<Playerscript>().points += 10;
            player_collider.GetComponent<Playerscript>().tasks++;

        }
    }

    public void Option04()
    {
        TextBox.GetComponent<Text>().text = "Odgovor D je netočan!";
        ChoiceMade = 4;

        player_collider = player.GetComponent<CapsuleCollider>();
        if (player_collider.tag == "Player")
        {
            player_collider.GetComponent<Playerscript>().points -= 3;
        }
    }

    void Update()
    {
        if (!player) { Debug.Log("Fali igrac"); }

        if (ChoiceMade == 3)
        {
            Choice01.SetActive(false);
            Choice02.SetActive(false);
            Choice03.SetActive(false);
            Choice04.SetActive(false);
        }
    }



}