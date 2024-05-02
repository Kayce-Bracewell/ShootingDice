namespace ShootingDice;
// TODO: Complete this class

// A Player who always rolls in the upper half of their possible role and
//  who throws an exception when they lose to the other player
public class SoreLoserUpperHalfPlayer : Player
{
    public override int Roll()
    {
        Random random = new Random();
        int tempInt = 0;
        while(tempInt <= 3)
        {
            tempInt = random.Next(DiceSize) + 1;
        }
        return tempInt;
    }

    public override void Play(Player other)
    {
        // Call roll for "this" object and for the "other" object
        int myRoll = Roll();
        int otherRoll = other.Roll();

        Console.WriteLine($"{Name} rolls a {myRoll}");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}");
        if (myRoll > otherRoll)
        {
            Console.WriteLine($"{Name} Wins!");
        }
        else if (myRoll < otherRoll)
        {
            throw new Exception("I can't deal! I quit!!");
        }
        else
        {
            // if the rolls are equal it's a tie
            Console.WriteLine("It's a tie");
        }
    }
}