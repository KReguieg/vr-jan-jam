using UnityEngine;

public class StateMachine
{
    public IState currentState;
    public IState previousState;


    public StateMachine()
    {
        Debug.Log(">>>>> StateMachine Created <<<<<");
    }

    public void ChangeState(IState state)
    {
        if (this.currentState != null)
            this.currentState.ExitState();

        this.previousState = this.currentState;
        this.currentState = state;

        state.EnterState();
    }

    public void ExecuteStateUpdate()
    {
        if (this.currentState != null)
            this.currentState.ExecuteState();
    }

    public void SwitchToPreviousState()
    {
        this.ChangeState(this.previousState);
    }
}
