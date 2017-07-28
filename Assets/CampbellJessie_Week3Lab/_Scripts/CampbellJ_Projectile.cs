using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CampbellJ_Projectile : MonoBehaviour {

    [SerializeField]
    CampbellJ_Plank plank;
    Vector3 plankToProjectile;
    Rigidbody2D thisRB;
    bool bHasStarted = false;

   
    // Use this for initialization
    void Start () {

        plankToProjectile = this.transform.position - plank.transform.position;

        thisRB = gameObject.GetComponent<Rigidbody2D>();

    }

    public void ResetProjectile()
    {
        bHasStarted = false;
    }

   

    // Update is called once per frame
    void Update () {
        if (!bHasStarted)
        {
            this.transform.position = plank.transform.position + plankToProjectile;

            if (Input.GetMouseButton(0))
            {
                thisRB.velocity = new Vector2(1.5f, 12.0f);
                bHasStarted = true;
            }
        }
	}

  
}
