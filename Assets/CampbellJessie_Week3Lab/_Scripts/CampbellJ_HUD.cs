using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CampbellJ_HUD : MonoBehaviour {

    CampbellJ_LevelManagement levelManage;
    
    int oldScore = -1;
    int oldLives = -1;

    Text scoreText;
    Text livesText;

    public void UpdateScore(int points)
    {

       CampbellJ_Data.score += points;
        Debug.Log(GameObject.FindGameObjectsWithTag("Block").Length);
        if(GameObject.FindGameObjectsWithTag("Block").Length == 1)
        {
            levelManage.AdvanceLevel();
        }

    }

    public void UpdateLives(int lives)
    {
        CampbellJ_Data.lives -= lives;
        if(CampbellJ_Data.lives <= 0)
        {
            levelManage.Lose();
        }
    }

    // Use this for initialization
    void Start()
    {
        scoreText = transform.FindChild("Score").GetComponent<Text>();
        livesText = transform.FindChild("Lives").GetComponent<Text>();
        levelManage = GameObject.Find("LevelManager").GetComponent<CampbellJ_LevelManagement>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(CampbellJ_Data.score != oldScore)
        {
            scoreText.text = "Score: " + CampbellJ_Data.score;
            oldScore = CampbellJ_Data.score;
        }

        if (CampbellJ_Data.lives != oldLives)
        {
            livesText.text = "Lives: " + CampbellJ_Data.lives;
            oldLives = CampbellJ_Data.lives;
        }

    }
}
