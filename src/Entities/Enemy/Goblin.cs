namespace ccad_collab;

public class Goblin : EnemyBaseClass
{
    EnemyType EnemyType { get; set; } = EnemyType.Goblin;
    int Health { get; set; } = 10;
    int Damage { get; set; } = 2;

    int Level { get; set; } = 1;
    int BaseXp { get; set; } = 10;

    string DroppedItem { get; set; } = "Gold";

    public override void Attack()
    {
        throw new NotImplementedException();
    }

    public override void TakeDamage(int damage)
    {
        throw new NotImplementedException();

    }
}