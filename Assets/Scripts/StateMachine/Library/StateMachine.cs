using UnityEngine;
using System.Collections;

public class StateMachine {

	public IState EntityState;

	public MonoBehaviour Subject;

	// constructor
	public StateMachine (MonoBehaviour subject) {
		this.Subject = Subject;
	}

	void updateState() {
		//handle input
		IState newState = EntityState.handleInput(Subject);
		if (newState != null) {
			EntityState.exit(Subject);
			EntityState = newState;
			EntityState.enter(Subject);
		}
		
		EntityState.update(Subject);
	}

	public void UpdateMachine () {
		updateState();
	}

}
