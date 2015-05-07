using UnityEngine;
using System.Collections;

public class IdleState : IState<PlayerController> {

	public override void Enter(PlayerController subject) {
		Debug.Log ("Enter Idle");
	}

	public override void Exit(PlayerController subject) {
		Debug.Log ("Exit Idle");
	}

	public override void Update(PlayerController subject) {

		if (Input.GetKeyDown(KeyCode.Space)) {
			//ganti state jadi jump
			subject.playerStateMachine.ChangeState(PlayerStates.jumpState);
		}else if (Input.GetKeyDown(KeyCode.Z)) {
			//ganti state jadi punch
			subject.playerStateMachine.ChangeState(PlayerStates.punchState);
		}

	}

}
