public class Player
{
    private string name;
    private int health;
    private int attackPower;
    private List<Item> inventory;

    public Player(string name, int health, int attackPower)
    {
        this.name = name;
        this.health = health;
        this.attackPower = attackPower;
        this.inventory = new List<Item>();
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Health
    {
        get { return health; }
        set { health = value; }
    }

    public int AttackPower
    {
        get { return attackPower; }
        set { attackPower = value; }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Console.WriteLine("Player has died");
        }
        else
        {
            Console.WriteLine($"{name} has taken {damage} damage and now has {health} health remaining!");
        }
    }

    public void Attack()
    {
        Console.WriteLine($"{name} attacks with {attackPower} power!");
    }

    public void Heal(int healAmount)
    {
        health += healAmount;
        Console.WriteLine($"{name} healed by {healAmount} and now has {health} health!");
    }

    public void AddItem(Item item)
    {
        inventory.Add(item);
        Console.WriteLine($"{item.Type} added to inventory.");
    }

    public void UseItem(Item item)
    {
        if (inventory.Contains(item))
        {
            Console.WriteLine($"Using item: {item.Type}");

            if (item.Type == "Healing Potion")
            {
                Heal(item.Damage);
            }
            else if (item.Type == "Attack Booster")
            {
                AttackPower += item.Damage;
                Console.WriteLine($"{name}'s attack power increased by {item.Damage}!");
            }

            inventory.Remove(item);
        }
        else
        {
            Console.WriteLine($"Item '{item.Type}' is not in the inventory.");
        }
    }
}