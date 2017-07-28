using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampbellJ_Plank : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Set a temporary plank position. (grab the plank's 'y position')
        Vector3 plankPosition = new Vector3(0.0f, this.transform.position.y, 0.0f);
       
        // Offset the mouse's position to the screen width by 0.5f
        float mouseOffset = Input.mousePosition.x - Screen.width * 0.5f;

        // Get the mouse movement in planks.
        float mouseInPlanks = mouseOffset / Screen.width * 16f;

        // Clamp the movement of the mouse to the planks width.
        plankPosition.x = Mathf.Clamp(mouseInPlanks, -7.7f, 7.7f);

        // Reset the planks position.
        this.transform.position = plankPosition;
	}
}
