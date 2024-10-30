using UnityEngine;
public class PlayerMoveState : PlayerState
{
    public PlayerMoveState(Player _player, PlayerStateMachine _stateMachine, string _animBoolName) : base(_player, _stateMachine, _animBoolName)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void Update()
    {
        base.Update();

        player.SetVelocity(player.moveSpeed * xInput, player.rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.N))
        {
            stateMachine.ChangeState(player.idleState);
        } 
    }
}
