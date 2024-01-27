namespace ccad_collab.Managers;

public class CombatRootState : IRootState
{
    bool IRootState.IsRootState { get; set; } = true;
}