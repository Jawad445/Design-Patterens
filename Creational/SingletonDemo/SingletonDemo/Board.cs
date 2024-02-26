namespace SingletonDemo;

public class Board
{
    public string BoardName { get; set; }
    public Board(string _boardName)
    {
        BoardName = _boardName;
        Console.WriteLine($"Connecting to {_boardName}");
    }

    public void Execute(string _programName)
    {
        Console.WriteLine($"Executing Program {_programName}");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i.ToString());
        }
    }

}
