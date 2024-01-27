namespace ccad_collab;

public class Rogue : PlayerBaseClass
{
    PlayerClassName PlayerClassName { get; } = PlayerClassName.Rogue;
    Proficiencies[] Proficiencies { get; } = [];
    double AvailbleInventorySpace { get; } = 90;
    int Strength { get; } = 8;
    int Dexterity { get; } = 15;
    int Constitution { get; } = 12;
    int Intelligence { get; } = 10;
    int Wisdom { get; } = 14;
    int Charisma { get; } = 10;

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}