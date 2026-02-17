namespace Snake;

public class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }

    // for comparing positions in lists
    public override bool Equals(object obj)
    {
        if (obj is Position pos)
            return X == pos.X && Y == pos.Y;
        return false;
    }

    public override int GetHashCode()
    {
        return X.GetHashCode() ^ Y.GetHashCode();
    }
}