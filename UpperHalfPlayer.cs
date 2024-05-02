namespace ShootingDice;
// TODO: Complete this class

// A Player whose role will always be in the upper half of their possible rolls
public class UpperHalfPlayer: Player
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
}