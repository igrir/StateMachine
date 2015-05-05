using UnityEngine;
using System.Collections;

public class PunchState : IEntityState {

	public override void enter(Entity entity) {
		Debug.Log ("Enter Punch");
		//contoh manggil ammo.
		((PlayerController)entity).Ammo--;
		//contoh kegunaan yang lain: ganti animasi dari controller
	}

	public override void exit(Entity entity) {
		Debug.Log ("Exit Punch");
	}

	public override IEntityState handleInput(Entity entity) {

		if (Input.GetKeyDown(KeyCode.Space)) {
			//ganti state jadi jump
			return PlayerStates.jumpState;

		}else if (Input.GetKeyDown(KeyCode.Z)) {
			//ganti state jadi punch (dari punch bisa punch lagi)
			return PlayerStates.punchState;
		}

		return null;
	}
	
	public override void update(Entity entity) {
	}
}
