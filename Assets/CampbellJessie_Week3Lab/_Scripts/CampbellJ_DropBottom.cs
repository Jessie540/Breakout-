using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampbellJ_DropBottom : MonoBehaviour {

    CampbellJ_Projectile ball;

    public CampbellJ_HUD hud;
   

	// Use this for initialization
	void Start () {
        ball = GameObject.FindObjectOfType<CampbellJ_Projectile>();
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        ball.ResetProjectile();
        hud.UpdateLives(1);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
