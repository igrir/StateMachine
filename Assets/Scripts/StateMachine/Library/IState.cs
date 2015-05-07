using UnityEngine;
using System.Collections;

public abstract class IState {
	public abstract IState handleInput(MonoBehaviour subject);
	public abstract void enter(MonoBehaviour subject);
	public abstract void exit(MonoBehaviour subject);
	public abstract void update(MonoBehaviour subject);

}
