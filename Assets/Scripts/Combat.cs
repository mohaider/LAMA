using UnityEngine;
using System.Collections;

public class Combat : MonoBehaviour {

	public enum BattleStates{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN,
	};

	public Transform Troop;
	public Transform CurrentMonster;
	static public BattleStates states;

	// Use this for initialization
	void Start () {
		states=BattleStates.START;
	}
	
	// Update is called once per frame
	void Update () {
		switch (states)
		{
		case BattleStates.START:
			//anything to do on start?
			break;
		case BattleStates.PLAYERCHOICE:
			//Player take their decision
			break;
		case BattleStates.ENEMYCHOICE:
			//ennemy attacks
			Monster monsterScript= CurrentMonster.GetComponent<Monster>();
			monsterScript.Attack(Troop);
			break;
		case BattleStates.LOSE:
			//you lose
			break;
		case BattleStates.WIN:
			//you win
			break;
		}
	
	}
}
