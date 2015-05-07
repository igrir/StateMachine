using UnityEngine;
using System.Collections;

public class IdleState : IState {

	public override void enter(MonoBehaviour subject) {
		Debug.Log ("Enter Idle");
	}

	public override void exit(MonoBehaviour subject) {
		Debug.Log ("Exit Idle");
	}

	public override IState handleInput(MonoBehaviour subject) {

		if (Input.GetKeyDown(KeyCode.Space)) {
			//ganti state jadi jump
			return PlayerStates.jumpState;
		}else if (Input.GetKeyDown(KeyCode.Z)) {
			//ganti state jadi punch
			return PlayerStates.punchState;
		}

		return null;
	}
	
	public override void update(MonoBehaviour subject) {
	}
}
