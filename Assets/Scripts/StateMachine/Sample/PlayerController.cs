using UnityEngine;
using System.Collections;

public class PlayerController : Entity {

	public int Ammo = 100;

	void Awake() {
		//initial state
		mEntityState = PlayerStates.idleState;
		mEntityState.enter(this);
	}

	// Use this for initialization
	void Start () {
	
	}

	void Update () {
		//call for state update
		base.Update();
	}
	
}
