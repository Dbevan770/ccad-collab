namespace ccad_collab.Managers;

public abstract class BaseState
{
    public SuperState CurrentSuperState { get; set; }

    public abstract void EnterState();

    public abstract void ExitState();

    public abstract void UpdateState();

    public abstract void SetSuperState(SuperState newState);

    public abstract void SetSubState();
}