using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampbellJ_WinBlock : MonoBehaviour {

    CampbellJ_LevelManagement levelManage;

    // Use this for initialization
    void Start () {
        levelManage = GameObject.Find("LevelManager").GetComponent<CampbellJ_LevelManagement>();
    }

    private void OnDestroy()
    {
        levelManage.Win();
    }
}
