using UnityEngine;
using System.Collections;

public abstract class IState <Entity> {
//	public abstract IState handleInput(Entity subject);
	public abstract void Enter(Entity subject);
	public abstract void Exit(Entity subject);
	public abstract void Update(Entity subject);

}
