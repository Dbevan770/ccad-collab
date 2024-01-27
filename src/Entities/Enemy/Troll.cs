namespace ccad_collab;

public class Troll : EnemyBaseClass
{
    EnemyType EnemyType { get; set; } = EnemyType.Troll;
    int Health { get; set; } = 20;
    int Damage { get; set; } = 5;

    int Level { get; set; } = 1;
    int BaseXp { get; set; } = 20;

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