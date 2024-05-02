namespace ShootingDice;

// TODO: Complete this class

// A player the prompts the user to enter a number for a roll
public class HumanPlayer : Player
{
    public override int Roll()
    {
        Console.WriteLine("Enter number to roll:");
        int rollNum = Convert.ToInt32(Console.ReadLine());
        return rollNum;
    }
}