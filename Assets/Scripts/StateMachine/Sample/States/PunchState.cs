using UnityEngine;
using System.Collections;

public class PunchState : IState {

	public override void enter(MonoBehaviour subject) {
		Debug.Log ("Enter Punch");
	}

	public override void exit(MonoBehaviour subject) {
		Debug.Log ("Exit Punch");
	}

	public override IState handleInput(MonoBehaviour subject) {

		if (Input.GetKeyDown(KeyCode.Space)) {
			//ganti state jadi jump
			return PlayerStates.jumpState;

		}else if (Input.GetKeyDown(KeyCode.Z)) {
			//ganti state jadi punch (dari punch bisa punch lagi)
			return PlayerStates.punchState;
		}

		return null;
	}
	
	public override void update(MonoBehaviour subject) {
	}
}
