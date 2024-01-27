namespace ccad_collab;

public class Spider : EnemyBaseClass
{
    EnemyType EnemyType { get; set; } = EnemyType.Spider;
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