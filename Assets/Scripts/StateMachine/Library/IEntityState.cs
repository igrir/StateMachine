using UnityEngine;
using System.Collections;

public abstract class IEntityState {
	public abstract IEntityState handleInput(Entity entity);
	public abstract void enter(Entity entity);
	public abstract void exit(Entity entity);
	public abstract void update(Entity entity);

}
