using UnityEngine;
using System.Collections;

public class CrowdMovement : MonoBehaviour {
    [SerializeField]
    Camera cam;
    bool triggerEvent = false;
    [SerializeField]
    float startPosition;
    [SerializeField]
    float endPosition;
    ArrayList players;
    // Use this for initialization
	void Start () {
        //players.
	}
	
	// Update is called once per frame
	void Update () {
        if (triggerEvent == false && cam.transform.position.x < endPosition && cam.transform.position.x > startPosition)
        {
            cam.transform.position += new Vector3(0.1f, 0, 0);
            transform.position += new Vector3(0.1f, 0, 0);
        }
	}

    public void setTriggerEvent(bool newTriggerEvent) {
        triggerEvent = newTriggerEvent;
    }
}
