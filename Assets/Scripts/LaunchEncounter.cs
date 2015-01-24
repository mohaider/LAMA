using UnityEngine;
using System.Collections;

public class LaunchEncounter : MonoBehaviour {

	public GameObject monster;
	public Vector3 monsterPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(){
		Instantiate(monster,monsterPosition, Quaternion.identity);
	}
}
