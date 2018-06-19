using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bodovi : MonoBehaviour {

    public GameObject player;
    public Text score_text;
    public bool Level2;
    public bool Level3;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        string jedan = "Sreća nije na tvojoj strani. Možda da drugi put upotrijebiš svoje znanje?";
        string dva = "Ocjena je prolazna, ali što stvarno ne znaš za višu ocjenu?";
        string tri = "Dobar, ali uvijek možeš bolje!";
        string cetiri = "Tvoje znanje je vrlo dobro, vidi se da nije rješavano na sreću.";
        string pet = "WOOOW, pa ti imaš odlično znanje!!!";

        int bodovi = player.GetComponent<Playerscript>().points;

        if (Level2 == true) {
             
            if (bodovi <= 35)
            {
                score_text.text = jedan;
            }

            else if (bodovi <= 41)
            {
                score_text.text = dva;
            }

            else if (bodovi <= 52)
            {
                score_text.text = tri;
            }

            else if (bodovi <= 62)
            {
                score_text.text = cetiri;
            }

            else if (bodovi >= 63)
            {
                score_text.text = pet;
            }
        }

        else if (Level3 == true)
        {
            if (bodovi <= 25)
            {
                score_text.text = jedan;
            }

            else if (bodovi <= 32)
            {
                score_text.text = dva;
            }

            else if (bodovi <= 37)
            {
                score_text.text = tri;
            }

            else if (bodovi <= 43)
            {
                score_text.text = cetiri;
            }

            else if (bodovi >= 44)
            {
                score_text.text = pet;
            }

        }


        else { 
        if (bodovi <= 50)
        {
            score_text.text = jedan;
        }

        else if (bodovi <= 59)
        {
            score_text.text = dva;
        }

        else if (bodovi <= 74)
        {
            score_text.text = tri;
        }

        else if (bodovi <= 89)
        {
            score_text.text = cetiri;
        }

        else if (bodovi >= 90)
        {
            score_text.text = pet;
        }
        }
    }
}
