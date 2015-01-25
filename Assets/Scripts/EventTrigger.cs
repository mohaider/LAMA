using UnityEngine;
using System.Collections;

public class EventTrigger : MonoBehaviour {

    bool activateBoss;
	
    void Start () {
        activateBoss = false;
	}
	
	void FixedUpdate () {
        //Placeholder to unstuck the camera
        if(Input.GetKeyDown(KeyCode.Space)){
            if (activateBoss == true)
            {
                GameObject.Find("Crowd").SendMessage("ActivateZoom", true);        
            }
            GameObject.Find("Crowd").SendMessage("SetTriggerEvent", false);
            print("space");
        }
	}

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.name.Equals("Crowd"))
        {
            if (transform.name.Equals("Treasure Box"))
            {
                obj.SendMessage("SetTriggerEvent", true);
            }
            if (transform.name.Equals("Enemy"))
            {
                obj.SendMessage("SetTriggerEvent", true);
            }
            if (transform.name.Equals("Boss"))
            {
                activateBoss = true;
                obj.SendMessage("SetTriggerEvent", true);
                obj.SendMessage("ActivateZoom", true);
            }
        } 
    }
}
