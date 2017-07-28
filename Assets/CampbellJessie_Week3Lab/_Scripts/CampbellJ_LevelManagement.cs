using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CampbellJ_LevelManagement : MonoBehaviour {

    string[] Levels = { "Level_01", "Level_02", "Level_03"};
    
	public void StartOfGame()
    {
        CampbellJ_Data.currentLevel = 0;
        ChangeLevel();
    }

    public void AdvanceLevel()
    {
        CampbellJ_Data.currentLevel++;
        if(CampbellJ_Data.currentLevel >= Levels.Length)
        {
            Win();
        }

        else
        {
            ChangeLevel();
        }
        
    }

    void ChangeLevel()
    {
        SceneManager.LoadScene(Levels[CampbellJ_Data.currentLevel]);
    }

    public void Win()
    {
        SceneManager.LoadScene("Win");
    }

    public void Lose()
    {
        SceneManager.LoadScene("Lose");
    }

    public void Restart()
    {
        SceneManager.LoadScene("Start");
    }
}
