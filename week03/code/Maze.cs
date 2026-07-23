public class Maze
{
    private readonly Dictionary<ValueTuple<int, int>, bool[]> _mazeMap;
    private int _currX = 1;
    private int _currY = 1;

    public Maze(Dictionary<ValueTuple<int, int>, bool[]> mazeMap)
    {
        _mazeMap = mazeMap;
    }

    /// <summary>
    /// Check to see if you can move left. If you can, then move. If you
    /// can't move, throw an InvalidOperationException with the message
    /// "Can't go that way!".
    /// </summary>
    public void MoveLeft()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions) && directions.Length >= 4 && directions[0])
        {
            _currX--;
            return;
        }

        throw new InvalidOperationException("Can't go that way!");
    }

    /// <summary>
    /// Check to see if you can move right. If you can, then move. If you
    /// can't move, throw an InvalidOperationException with the message
    /// "Can't go that way!".
    /// </summary>
    public void MoveRight()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions) && directions.Length >= 4 && directions[1])
        {
            _currX++;
            return;
        }

        throw new InvalidOperationException("Can't go that way!");
    }

    /// <summary>
    /// Check to see if you can move up. If you can, then move. If you
    /// can't move, throw an InvalidOperationException with the message
    /// "Can't go that way!".
    /// </summary>
    public void MoveUp()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions) && directions.Length >= 4 && directions[2])
        {
            _currY--;
            return;
        }

        throw new InvalidOperationException("Can't go that way!");
    }

    /// <summary>
    /// Check to see if you can move down. If you can, then move. If you
    /// can't move, throw an InvalidOperationException with the message
    /// "Can't go that way!".
    /// </summary>
    public void MoveDown()
    {
        if (_mazeMap.TryGetValue((_currX, _currY), out bool[] directions) && directions.Length >= 4 && directions[3])
        {
            _currY++;
            return;
        }

        throw new InvalidOperationException("Can't go that way!");
    }

    public string GetStatus()
    {
        return $"Current location (x={_currX}, y={_currY})";
    }
}