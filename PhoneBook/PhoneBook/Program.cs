using PhoneBook;
BookActions bookActions = new BookActions();
int input;
do { 
Console.WriteLine("Please select the operation you want to perform : \n*************************\n(1) Add a New Number\n(2) Delete the Existing Number\n" +
    "(3) Update the Existing Number\n(4) List The Directory\n(5) Search in the Directory\n(0) Exit");
       input = int.Parse(Console.ReadLine());
    switch (input)
    {
        case 1:
            bookActions.AddPhoneNumber();
            break;
        case 2:
            bookActions.DeletePhoneNumber();
            break;
        case 3:
            bookActions.UpdatePhoneNumber();
            break;
        case 4:
            bookActions.GetAllList();
            break;
        case 5:
            bookActions.SearchNumber();
            break;
        case 0:
            Console.WriteLine("Exit");
            break;
        default:
            Console.WriteLine("Invalid transaction number, try again.");
            break;
    }
}while (input != 0);