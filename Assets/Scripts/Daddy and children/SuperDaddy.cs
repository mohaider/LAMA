using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SuperDaddy : MonoBehaviour {
    Character[] children;
    float votingTimer = 10.0f;
   
        static public int bucket1, bucket2, bucket3;


    

    


	// Use this for initialization
	void Start () {
        children = gameObject.GetComponentsInChildren<Character>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartTheVoting()
    {
        for (int i = 0; i < children.Length; i++)
        {
            children[i].EnableVoting();
                    
        }
        


    }
    private class votingManager
    {
        string vote1, vote2, vote3;

        public void getVotes(string vote)
        { 
        
        
        }
    
    
    }



}

