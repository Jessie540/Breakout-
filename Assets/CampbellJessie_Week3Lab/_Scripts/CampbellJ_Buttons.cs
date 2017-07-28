using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampbellJ_Buttons : MonoBehaviour {

    Button start;
    Button quit;

    CampbellJ_LevelManagement levelManage;
   
	void Start ()
    {
       start = transform.FindChild("Start").GetComponent<Button>();
       quit = transform.FindChild("Exit").GetComponent<Button>();
       start.onClick.AddListener(OnStartClick);
       quit.onClick.AddListener(OnQuitClick);
       levelManage = GameObject.Find("LevelManager").GetComponent<CampbellJ_LevelManagement>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
    
    void OnStartClick()
    {
        levelManage.StartOfGame();
    }

    void OnQuitClick()
    {
        Application.Quit();
    }
}
