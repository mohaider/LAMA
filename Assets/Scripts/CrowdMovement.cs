using UnityEngine;
using System.Collections;

public class CrowdMovement : MonoBehaviour {
    [SerializeField]
    Camera cam;
    [SerializeField]
    GameObject scene;
    
    bool triggerEvent = false;
    [SerializeField]
    float startPosition;
    [SerializeField]
    float endPosition;
    
    ArrayList players;

    float zoomCooldown;
    bool zoomIn;
    bool activateZoom;

    // Use this for initialization
	void Start () {
        //players.
        zoomCooldown = Time.time;
        zoomIn = false;

	}
	
	// Update is called once per frame
    void FixedUpdate()
    {
        if (activateZoom == true)
        {
            Zoom();
        } else if (triggerEvent == false && cam.transform.position.x < endPosition && cam.transform.position.x > startPosition)
        {
            cam.transform.position += new Vector3(0.1f, 0, 0);
            transform.position += new Vector3(0.1f, 0, 0);
        }
	}

    public void SetTriggerEvent(bool newTriggerEvent) {
        triggerEvent = newTriggerEvent;
    }

    public void ActivateZoom(bool activate) {
        activateZoom = activate;
        if (activate == true)
        {
            zoomCooldown = Time.time;
        }
    }

    void Zoom() {

        if (Time.time - 0.5f < zoomCooldown)
        {
            if (zoomIn == true)
            {
                scene.transform.localScale += new Vector3(0.01f, 0.01f, 0);
                scene.transform.position += new Vector3(-0.09f, 0.0135f, 0);
            }
            else
            {
                scene.transform.localScale -= new Vector3(0.01f, 0.01f, 0);
                scene.transform.position -= new Vector3(-0.09f, 0.0135f, 0);
            }

        }
        else if (Time.time - 0.5f > zoomCooldown)
        {
            activateZoom = false;
            if (zoomIn == false)
            {
                zoomIn = true;
            }
            else
            {
                zoomIn = false;

                scene.transform.localScale = new Vector3(1, 1, 1);
                scene.transform.position = new Vector3(-9.540632f, -1.966668f, -1);
            }
        }
    }
}
