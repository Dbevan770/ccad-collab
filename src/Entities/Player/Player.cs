namespace ccad_collab;

public class Player(string name, PlayerClassName className)
{
    public string Name { get; set; } = name;
    public int Health { get; set; } = 20;
    public PlayerClassName ClassName { get; set; } = className;
}