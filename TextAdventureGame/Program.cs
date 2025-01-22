using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the game!");

        Player player = new Player("Cameron", 100, 20);

        Item healingPotion = new Item("Healing Potion", 30);
        Item attackBooster = new Item("Attack Booster", 10);

        player.AddItem(healingPotion);
        player.AddItem(attackBooster);

        player.TakeDamage(25);

        player.UseItem(healingPotion);
        player.UseItem(attackBooster);

        Item fakeItem = new Item("Fake Item", 0);
        player.UseItem(fakeItem);

        Console.WriteLine("Game over.");
    }
}