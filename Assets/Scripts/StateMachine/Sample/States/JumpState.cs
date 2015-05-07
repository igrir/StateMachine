using UnityEngine;
using System.Collections;

public class JumpState : IState {
	
	public override void enter(MonoBehaviour subject) {
		Debug.Log ("Enter jump");
	}

	public override void exit(MonoBehaviour subject) {
		Debug.Log ("Exit jump");
	}
	
	public override IState handleInput(MonoBehaviour subject) {

		//ganti state jadi jump
		if (Input.GetKeyDown(KeyCode.Space)) {
			return PlayerStates.idleState;
		}
		//di jump tapi nggak bisa punch

		return null;
	}
	
	public override void update(MonoBehaviour subject) {
	}
}
