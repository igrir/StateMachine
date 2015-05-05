using UnityEngine;
using System.Collections;

public class IdleState : IEntityState {

	public override void enter(Entity entity) {
		Debug.Log ("Enter Idle");
	}

	public override void exit(Entity entity) {
		Debug.Log ("Exit Idle");
	}

	public override IEntityState handleInput(Entity entity) {

		if (Input.GetKeyDown(KeyCode.Space)) {
			//ganti state jadi jump
			return PlayerStates.jumpState;
		}else if (Input.GetKeyDown(KeyCode.Z)) {
			//ganti state jadi punch
			return PlayerStates.punchState;
		}

		return null;
	}
	
	public override void update(Entity entity) {
	}
}
