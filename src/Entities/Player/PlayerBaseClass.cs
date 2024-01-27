namespace ccad_collab;

public abstract class PlayerBaseClass
{
    PlayerClassName PlayerClassName { get; set; }
    Proficiencies[] Proficiencies { get; set; } = new Proficiencies[3];
    double AvailbleInventorySpace { get; set; }
    int Strength { get; set; }
    int Dexterity { get; set; }
    int Constitution { get; set; }
    int Intelligence { get; set; }
    int Wisdom { get; set; }
    int Charisma { get; set; }

    public abstract void LevelUp();
}