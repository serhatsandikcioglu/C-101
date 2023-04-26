using ToDo;
ToDoActions toDoActions = new ToDoActions();
int input;
do
{
    Console.WriteLine("Please select the operation you want to perform : \n*************************\n(1) List The Board\n(2) Add a Card to the Board\n" +
        "(3) Delete a Card from the Board\n(4) Move the Card\n(0) Exit");
    input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            toDoActions.ListBoard();
            break;
        case 2:
            toDoActions.AddCard();
            break;
        case 3:
            toDoActions.DeleteCard();
            break;
        case 4:
            toDoActions.MoveCard();
            break;
        case 0:
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Invalid transaction number, try again.");
            break;
    }
} while (input != 0);