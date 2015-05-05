using UnityEngine;
using System.Collections;

public class Entity : MonoBehaviour {

	public IEntityState mEntityState;


	void updateState() {
		//handle input
		IEntityState newState = mEntityState.handleInput(this);
		if (newState != null) {
			mEntityState.exit(this);
			mEntityState = newState;
			mEntityState.enter(this);
		}
		
		mEntityState.update(this);
	}

	public void Update () {
		updateState();
	}

}
