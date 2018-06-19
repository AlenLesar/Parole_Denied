using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class EnemyAttacking : FsmState {

    public GameObject panel;
    public GameObject playerCamera;
    public GameObject panelCamera;


    // Use this for initialization
    void Start() {
		
	}
	
	// Update is called once per frame
	void Update () {

        panel.SetActive(true);
        playerCamera.SetActive(false);
        panelCamera.SetActive(true);

        if (Input.GetKeyDown(KeyCode.E)) {
            SceneManager.LoadScene("Level_3"); }
    }
}
