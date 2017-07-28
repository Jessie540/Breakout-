using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampbellJ_WinScreen : MonoBehaviour
{

    Button restart;


    CampbellJ_LevelManagement levelManage;

    void Start()
    {
        restart = transform.FindChild("Restart").GetComponent<Button>();

        restart.onClick.AddListener(OnStartClick);

        levelManage = GameObject.Find("LevelManager").GetComponent<CampbellJ_LevelManagement>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnStartClick()
    {
        levelManage.Restart();
    }


}
