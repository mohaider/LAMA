using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour {
	public int Hp;
	public int atq;




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Attack(Transform Troop){
		Character[] charactersScript =Troop.GetComponentsInChildren<Character>();
		for (int i=0;i<charactersScript.Length;i++){
			charactersScript[i].ReceiveDamages(atq);
		}

	}

	public void ReceiveDamages(int atq){
		Hp-=atq;
		if(Hp<=0){
			Die();
		}

	}

	public void Die(){

	}
}
