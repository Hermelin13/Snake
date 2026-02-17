namespace Snake;

public class Food
{
    public Position Position { get; set; }
    public ConsoleColor Color { get; private set; }

    public Food()
    {
        Position = new Position(0, 0);
        Color = ConsoleColor.Cyan;
    }

    public void Regenerate(Random random, int maxX, int maxY)
    {
        Position = new Position(
            random.Next(1, maxX - 2),
            random.Next(1, maxY - 2)
        );
    }
}