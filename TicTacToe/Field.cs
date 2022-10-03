namespace TicTacToe;

public class Field
{
    private char[,] _box = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

    public bool AddWalk(int i, int j, char walk)
    {
        try
        {
            if (_box[i - 1, j - 1] == ' ')
                _box[i - 1, j - 1] = walk;
            else
                return false;
        }
        catch (IndexOutOfRangeException)
        {
            return false;
        }

        return true;
    }


    public void DrawField()
    {
        // Console.WriteLine("-1-2-3-");
        Console.WriteLine(_box[0, 0] + "|" + _box[0, 1] + "|" + _box[0, 2]);
        Console.WriteLine("------");
        Console.WriteLine(_box[1, 0] + "|" + _box[1, 1] + "|" + _box[1, 2]);
        Console.WriteLine("------");
        Console.WriteLine(_box[2, 0] + "|" + _box[2, 1] + "|" + _box[2, 2]);
    }

    public bool ItHaveEmptyBox()
    {
        int emptyBoxs = 0;
        foreach (char c in _box)
        {
            if (c == ' ')
                emptyBoxs++;
        }
        return emptyBoxs != 0;
    }

    public bool CheckWin()
    {
        if (
            (_box[0, 0] != ' ' && _box[0, 0] == _box[0, 1] && _box[0, 0] == _box[0, 2])
            || (_box[0, 0] != ' ' && _box[0, 0] == _box[1, 0] && _box[0, 0] == _box[2, 0])
            || (_box[0, 0] != ' ' && _box[0, 0] == _box[1, 1] && _box[0, 0] == _box[2, 2])
            || (_box[2, 0] != ' ' && _box[2, 0] == _box[1, 1] && _box[2, 0] == _box[0, 2])
            || (_box[2, 2] != ' ' && _box[2, 2] == _box[2, 1] && _box[2, 2] == _box[2, 0])
            || (_box[2, 2] != ' ' && _box[2, 2] == _box[1, 2] && _box[2, 2] == _box[0, 2])
            || (_box[0, 1] != ' ' && _box[0, 1] == _box[1, 1] && _box[0, 1] == _box[2, 1])
            || (_box[1, 0] != ' ' && _box[1, 0] == _box[1, 1] && _box[1, 0] == _box[1, 2])
        )
        {
            return true;
        }

        return false;
    }
}