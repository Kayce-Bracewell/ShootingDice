namespace ShootingDice;
// TODO: Complete this class

// A Player who shouts a taunt every time they roll dice
public class SmackTalkingPlayer : Player
{
    public string Taunt { get; } = "you suck!";

    public override int Roll()
    {
        int roll = base.Roll();
        Console.WriteLine($"{Name} shouts: {Taunt}");
        return roll;
    }
}