namespace ccad_collab;

public class Wizard : PlayerBaseClass
{
    PlayerClassName PlayerClassName { get; } = PlayerClassName.Wizard;
    Proficiencies[] Proficiencies { get; } = [];
    double AvailbleInventorySpace { get; } = 60;
    int Strength { get; } = 8;
    int Dexterity { get; } = 10;
    int Constitution { get; } = 12;
    int Intelligence { get; } = 15;
    int Wisdom { get; } = 14;
    int Charisma { get; } = 10;

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}