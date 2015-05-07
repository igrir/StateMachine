using UnityEngine;
using System.Collections;

public class JumpState : IState<PlayerController> {
	
	public override void Enter(PlayerController subject) {
		Debug.Log ("Enter Jump");
	}
	
	public override void Exit(PlayerController subject) {
		Debug.Log ("Exit Jump");
	}
	
	public override void Update(PlayerController subject) {
		
		if (Input.GetKeyDown(KeyCode.Space)) {
			//ganti state jadi idle
			subject.playerStateMachine.ChangeState(PlayerStates.idleState);
		}

	}

}
