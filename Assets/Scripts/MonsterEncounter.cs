using UnityEngine;
using System.Collections;

public class MonsterEncounter : MonoBehaviour {

	public ArrayList DecisionList;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Print(){ //OnGUI?
		#if UNITY_IPHONE
		Debug.Log("Iphone");
		#endif
		
		#if UNITY_STANDALONE_OSX
		Debug.Log("Stand Alone OSX");
		#endif
		
		#if UNITY_STANDALONE_WIN
		Debug.Log("Stand Alone Windows");
		#endif
		
		
		#if UNITY_ANDROID 
		
		#endif
	}

}
