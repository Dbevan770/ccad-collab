namespace ccad_collab;

public class Slime : EnemyBaseClass
{
    EnemyType EnemyType { get; set; } = EnemyType.Slime;
    int Health { get; set; } = 5;
    int Damage { get; set; } = 1;

    int Level { get; set; } = 1;
    int BaseXp { get; set; } = 5;

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