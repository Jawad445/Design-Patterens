namespace SingletonDemo;

public sealed class Board
{
    public static Board Instance;
    public string BoardName { get; set; }
    private Board() { }

    public static Board CreateBoard(string _boardName)
    {
        if (Instance == null)
        {
            Instance = new Board();
            Instance.BoardName = _boardName;
            Console.WriteLine($"Connection to {_boardName} created");
        }
        return Instance;
    }
    
    public void Execute(string _programName)
    {
        Console.WriteLine($"Executing Program {_programName} on {Instance.BoardName}");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(i.ToString());
        }
    }
}
