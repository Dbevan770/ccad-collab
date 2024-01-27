namespace ccad_collab;

public class Orc : EnemyBaseClass
{
    EnemyType EnemyType { get; set; } = EnemyType.Orc;
    int Health { get; set; } = 15;
    int Damage { get; set; } = 3;

    int Level { get; set; } = 1;
    int BaseXp { get; set; } = 15;

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