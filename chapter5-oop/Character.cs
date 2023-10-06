namespace chapter5_oop;

/* internal - by default. will not be visible in chapter5-addition */ public class Character
{
    // private int _health = 100;
    //
    // public int Health
    // {
    //     get
    //     {
    //         return _health;
    //     }
    //     private set
    //     {
    //         _health = value;
    //     }
    // }

    public int Health { get; private set; } = 100;

    public void Hit(int damage)
    {
        if (damage > Health)
            damage = Health;

        Health -= damage;
    }
}