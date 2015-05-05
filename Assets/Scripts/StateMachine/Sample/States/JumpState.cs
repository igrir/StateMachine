using UnityEngine;
using System.Collections;

public class JumpState : IEntityState {
	
	public override void enter(Entity entity) {
		Debug.Log ("Enter jump");
	}

	public override void exit(Entity entity) {
		Debug.Log ("Exit jump");
	}
	
	public override IEntityState handleInput(Entity entity) {

		//ganti state jadi jump
		if (Input.GetKeyDown(KeyCode.Space)) {
			return PlayerStates.idleState;
		}
		//di jump tapi nggak bisa punch

		return null;
	}
	
	public override void update(Entity entity) {
	}
}
