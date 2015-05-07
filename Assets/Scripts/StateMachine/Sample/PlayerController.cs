using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int Ammo = 100;

	public StateMachine<PlayerController> playerStateMachine;

	void Awake() {

		playerStateMachine = new StateMachine<PlayerController>(this);

		//initial state
		playerStateMachine.ChangeState(PlayerStates.idleState);
	}

	// Use this for initialization
	void Start () {
	
	}

	void Update () {
		//call for state update
		playerStateMachine.Update();
	}
	
}
