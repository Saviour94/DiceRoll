using System;

public class Die
{
    private Random random;
    public int DieFace { get; private set; }
    public Die()
    {
        random = new Random();
        Roll();
    }

// Rolls a random number between 1 and 6
    public int Roll()
    {
        DieFace = random.Next(1, 7); 
        return DieFace;
    }
}

public class Game
{
    private Die[] dice;

    public Game()
    {
        dice = new Die[3];
        for (int i = 0; i < 3; i++)
        {
            dice[i] = new Die();
        }
    }

    public int DiceRoll()
    {
        int total = 0;
        foreach (var die in dice)
        {
            total += die.Roll();
        }
        return total;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-----------------------");
        Console.WriteLine("Welcome to Dice Roller!");
        Console.WriteLine("-----------------------");

        Game game = new Game();

        int total = game.DiceRoll();

        Console.WriteLine($"You rolled a total of: {total}");
    }
}