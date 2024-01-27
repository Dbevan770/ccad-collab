namespace ccad_collab.Managers;

public enum SuperState
{
    Combat,
    Menu,
    Conversation,
    Overworld
}

public enum CombatSubState
{
    PlayerTurn,
    EnemyTurn,
    PlayerWin,
    PlayerLose
}