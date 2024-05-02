using ShootingDice;

Player player1 = new Player();
player1.Name = "Bob";

Player player2 = new Player();
player2.Name = "Sue";

player2.Play(player1);

Console.WriteLine("-------------------");

Player player3 = new Player();
player3.Name = "Wilma";

player3.Play(player2);

Console.WriteLine("-------------------");

Player large = new LargeDicePlayer();
large.Name = "Bigun Rollsalot";

player1.Play(large);

Console.WriteLine("-------------------");

Player smackTalker = new SmackTalkingPlayer();
smackTalker.Name = "Guy Fierri";

large.Play(smackTalker);

Console.WriteLine("-------------------");

Player oneHigherRoller = new OneHigherPlayer();
oneHigherRoller.Name = "Gioseppe";

oneHigherRoller.Play(smackTalker);

Console.WriteLine("-------------------");

Player HumanPlayer = new HumanPlayer();
HumanPlayer.Name = "Definitely Human";

HumanPlayer.Play(oneHigherRoller);

Console.WriteLine("-------------------");

Player CreativeSmackTalker = new CreativeSmackTalkingPlayer();
CreativeSmackTalker.Name = "Creative Conniver";

CreativeSmackTalker.Play(HumanPlayer);

Console.WriteLine("-------------------");

Player SoreLoser = new SoreLoserPlayer();
SoreLoser.Name = "Losing Lucy";

SoreLoser.Play(CreativeSmackTalker);

Console.WriteLine("-------------------");

Player UpperBound = new UpperHalfPlayer();
UpperBound.Name = "Jesus";

UpperBound.Play(SoreLoser);

Console.WriteLine("-------------------");

Player Cheater = new SoreLoserUpperHalfPlayer();
Cheater.Name = "Falsio";

Cheater.Play(UpperBound);

Console.WriteLine("-------------------");

List<Player> players = new List<Player>() {
    player1, player2, player3, large, smackTalker, oneHigherRoller, HumanPlayer, CreativeSmackTalker, SoreLoser, UpperBound, Cheater
};

PlayMany(players);

static void PlayMany(List<Player> players)
{
    Console.WriteLine();
    Console.WriteLine("Let's play a bunch of times, shall we?");

    // We "order" the players by a random number
    // This has the effect of shuffling them randomly
    Random randomNumberGenerator = new Random();
    List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

    // We are going to match players against each other
    // This means we need an even number of players
    int maxIndex = shuffledPlayers.Count;
    if (maxIndex % 2 != 0)
    {
        maxIndex = maxIndex - 1;
    }

    // Loop over the players 2 at a time
    for (int i = 0; i < maxIndex; i += 2)
    {
        Console.WriteLine("-------------------");

        // Make adjacent players play noe another
        Player player1 = shuffledPlayers[i];
        Player player2 = shuffledPlayers[i + 1];
        player1.Play(player2);
    }
}