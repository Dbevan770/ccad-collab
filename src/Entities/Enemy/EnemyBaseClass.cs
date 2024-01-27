namespace ccad_collab;

public abstract class EnemyBaseClass
{
    EnemyType EnemyType { get; set; }
    int Health { get; set; }
    int Damage { get; set; }

    // TODO: Add armor and damage resistence

    int Level { get; set; }
    int BaseXp { get; set; }

    // TODO: Change to Item class
    string DroppedItem { get; set; }

    public abstract void Attack();

    public abstract void TakeDamage(int damage);
}
