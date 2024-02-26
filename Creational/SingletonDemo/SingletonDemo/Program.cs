using SingletonDemo;

//var board1 = Board.CreateBoard("Jawad Board");
//board1.Execute("program 1");


//var board2 = Board.CreateBoard("Hamza Board");
//board2.Execute("Program 2");

Board board1 = null;
Board board2 = null;
Board board3 = null;

Task task1 = Task.Factory.StartNew(()=>
{
    board1 = Board.CreateBoard("Jawad Board");
});

Task task2 = Task.Factory.StartNew(() =>
{
    board2 = Board.CreateBoard("Hamza Board");
});

Task task3 = Task.Factory.StartNew(() =>
{
    board3 = Board.CreateBoard("Ali Board");
});

Task.WaitAll(task1 , task2, task3);

Console.WriteLine("All thread completed");
