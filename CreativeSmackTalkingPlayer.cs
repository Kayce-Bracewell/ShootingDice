namespace ShootingDice;
// A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player

public class CreativeSmackTalkingPlayer : Player
{
    private List<string> taunts = new List<string>()
    {
        "Go back to basics!",
        "You're a chump.",
        "Give it up already.",
        "Are you stupid?"
    };

    private Random random = new Random();

    public override int Roll()
    {
        string selectedTaunt = taunts[random.Next(taunts.Count)];
        Console.WriteLine($"{Name} shouts: {selectedTaunt}");
        return base.Roll();
    }
}