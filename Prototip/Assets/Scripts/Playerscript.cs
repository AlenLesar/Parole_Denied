using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour {

    public int cards = 0;

    public int tasks = 0;

    public int points = 0;

    public bool Level2;
    public bool Level3;


    // Use this for initialization
    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update() {

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

    private void OnGUI()
    {

        GUIStyle style = new GUIStyle();
        style.font = (Font)Resources.Load("my_font2", typeof(Font));
        style.fontSize = 35;
        style.normal.textColor = Color.white;

        if (Level2 == true) {
            GUI.Label(new Rect(30, 100, 1000, 50), "Kartice : " + cards + "/7", style);
        }

        else if(Level3 == true)
        {
            GUI.Label(new Rect(30, 100, 1000, 50), "Kartice : " + cards + "/5", style);
        }

        else { 
        GUI.Label(new Rect(30, 100, 1000, 50), "Kartice : " + cards + "/10", style);
        }
        GUI.Label(new Rect(30, 150, 1000, 50), "Bodovi : " + points, style);

        if (Level2 == true)
        {
            GUI.Label(new Rect(30, 200, 1000, 50), "Pitanja : " + tasks + "/7", style);
        }
        else if (Level3 == true){
            GUI.Label(new Rect(30, 200, 1000, 50), "Pitanja : " + tasks + "/5", style);
        }

        else { GUI.Label(new Rect(30, 200, 1000, 50), "Pitanja : " + tasks + "/10", style); }

    }

}
