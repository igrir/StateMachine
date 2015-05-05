using UnityEngine;
using System.Collections;

public class PlayerStates {

	//for lightweight accessing of states
	public static IdleState idleState = new IdleState();
	public static JumpState jumpState = new JumpState();
	public static PunchState punchState = new PunchState();

}
