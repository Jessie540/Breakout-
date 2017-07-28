using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampbellJ_Block : MonoBehaviour
{
    [SerializeField]
    CampbellJ_HUD hud;
    
    [SerializeField]
    int maxHits;
    int hitsTaken;

    bool hits;
    
    // Use this for initialization
    void Start()
    {
        hitsTaken = 0;

    }
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        
        hud.UpdateScore(1);
        hitsTaken++;
        if (hitsTaken >= maxHits)
        {

            Destroy(gameObject);

        }



    }



    // Update is called once per frame
    void Update()
    {

    }




}
