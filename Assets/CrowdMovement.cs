using UnityEngine;
using System.Collections;

public class CrowdMovement : MonoBehaviour {
    [SerializeField]
    Camera cam;
    bool triggerEvent = false;
    // Use this for initialization
	void Start () {
	        
	}
	
	// Update is called once per frame
	void Update () {
        if (triggerEvent == false)
        {
            cam.transform.position += new Vector3(0.1f, 0, 0);
            transform.position += new Vector3(0.1f, 0, 0);
        }
	}

    public void setTriggerEvent(bool newTriggerEvent) {
        triggerEvent = newTriggerEvent;
    }
}
