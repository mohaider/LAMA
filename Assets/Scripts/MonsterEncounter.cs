using UnityEngine;
using System.Collections;

public class MonsterEncounter : MonoBehaviour {

	public ArrayList DecisionList;

	// Use this for initialization
	void Start () {
		DecisionList.Add("Attack");
		DecisionList.Add(" Defend / Dodge");                
		DecisionList.Add("flee");
		DecisionList.Add("Build a shelter / Hide");
		DecisionList.Add("Sacrifice a member of the team");
		DecisionList.Add("Sabotage the group decision");

	
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
