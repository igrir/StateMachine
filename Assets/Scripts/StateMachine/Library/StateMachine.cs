using UnityEngine;
using System.Collections;

public class StateMachine <Entity> {

	private IState<Entity> m_CurrentState;
	private IState<Entity> m_PreviousState;
	private IState<Entity> m_GlobalState;

	private Entity _Subject;

	// constructor
	public StateMachine (Entity subject) {
		this._Subject = subject;
	}

	public void ChangeState(IState<Entity> newState) {
		//handle input
		if (newState != null) {
			m_PreviousState = m_CurrentState;

			if (m_CurrentState != null) {
				m_CurrentState.Exit(_Subject);
			}

			m_CurrentState = newState;
			m_CurrentState.Enter(_Subject);
		}

	}

	public void Update() {
		if (m_GlobalState != null) {
			m_GlobalState.Update(_Subject);
		}
		if (m_CurrentState != null) {
			m_CurrentState.Update(_Subject);
		}
	}

}
