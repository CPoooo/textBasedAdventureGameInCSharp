public class Item
{
    private string type;
    private int damage;

    public Item(string type, int damage)
    {
        this.type = type;
        this.damage = damage;
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public int Damage
    {
        get { return damage; }
        set { damage = value; }
    }
}