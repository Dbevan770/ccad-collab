namespace ccad_collab;

public class Warrior() : PlayerBaseClass
{
    PlayerClassName PlayerClassName { get; } = PlayerClassName.Warrior;
    Proficiencies[] Proficiencies { get; } = [];
    double AvailbleInventorySpace { get; } = 120;
    int Strength { get; } = 15;
    int Dexterity { get; } = 10;
    int Constitution { get; } = 14;
    int Intelligence { get; } = 8;
    int Wisdom { get; } = 12;
    int Charisma { get; } = 10;

    public override void LevelUp()
    {
        throw new NotImplementedException();
    }
}