using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int Ammo = 100;

	StateMachine playerStateMachine;

	void Awake() {

		playerStateMachine = new StateMachine(this);

		//initial state
		playerStateMachine.EntityState = PlayerStates.idleState;
	}

	// Use this for initialization
	void Start () {
	
	}

	void Update () {
		//call for state update
		playerStateMachine.UpdateMachine();
	}
	
}
