using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    public class ToDoActions
    {
        Board board = new Board();
        List<Person> persons = new List<Person>();
        public ToDoActions()
        {
            persons.Add(new Person(1, "Name1", "Surname1"));
            persons.Add(new Person(2, "Name2", "Surname2"));
            persons.Add(new Person(3, "Name3", "Surname3"));
            board.ToDo.Add(new Card("Title1", "Content1", 1, Card.cardSizeType.XS));
            board.ToDo.Add(new Card("Title2", "Content2", 2, Card.cardSizeType.XL));
            board.ToDo.Add(new Card("Title3", "Content3", 3, Card.cardSizeType.M));
        }
        public void AddCard()
        {
            Console.Write("Başlık Giriniz: ");
            var title = Console.ReadLine();
            Console.Write("İçerik Giriniz: ");
            var content = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)");
            var size = int.Parse(Console.ReadLine());
            Card.cardSizeType selectedSize = (Card.cardSizeType)size;
            Console.Write("Kişi Seçiniz: ");
            int personId = int.Parse(Console.ReadLine());
            int counter = 0;
            foreach (Person item in persons)
            {
                if (item.Id == personId)
                {
                    counter++;
                    board.ToDo.Add(new Card(title, content, personId, selectedSize));
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("You have made incorrect entries!");
            }
            else
            {
                Console.WriteLine("The Card Was Added Successfully");
            }

        }
        public void DeleteCard()
        {
            Console.WriteLine("First of all, you need to select the card that you want to delete.\nPlease write the card title: ");
            var title = Console.ReadLine();
            var counter = 0;
            for (int i = 0; i < board.ToDo.Count; i++)
            {
                if (board.ToDo[i].Title.ToLower() == title.ToLower())
                {
                    Console.WriteLine(board.ToDo[i].Title +" Has Been Deleted");
                    board.ToDo.Remove(board.ToDo[i]);
                    counter++;
                }
            }
            for (int i = 0; i < board.InProgress.Count; i++)
            {
                if (board.InProgress[i].Title.ToLower() == title.ToLower())
                {
                    Console.WriteLine(board.ToDo[i].Title + " Has Been Deleted");
                    board.InProgress.Remove(board.InProgress[i]);
                    counter++;
                }
            }
            for (int i = 0; i < board.Done.Count; i++)
            {
                if (board.Done[i].Title.ToLower() == title.ToLower())
                {
                    Console.WriteLine(board.ToDo[i].Title + " Has Been Deleted");
                    board.Done.Remove(board.Done[i]);
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("The card suitable for the criteria you are looking for could not be found on the board. Please make a choice.\n* To terminate the deletion : (1)\n* To try again: (2)");
                var input = int.Parse(Console.ReadLine());
                if (input == 1)
                {

                }
                else if (input == 2)
                {
                    DeleteCard();
                }
            }
        }
        public void MoveCard()
        {
            Console.WriteLine("First of all, you need to select the card that you want to move.\nPlease write the card title: ");
            var title = Console.ReadLine();
            var counter = 0;
            var toDoList = board.ToDo.ToList();
            var inProgressList = board.InProgress.ToList();
            var doneList = board.Done.ToList();
            for (int i = 0; i < toDoList.Count; i++)
            {
                if (toDoList[i].Title.ToLower() == title.ToLower())
                {
                    var personName = persons.FirstOrDefault(x => x.Id == board.ToDo[i].PersonId)?.Name;
                    Console.WriteLine("Title: " + board.ToDo[i].Title + "\nContent: " + board.ToDo[i].Content + "\nPerson: " + personName + "\nSize: " + board.ToDo[i].Size + "\nLine: ToDo" + "\nPlease select the Line you want to move: (1) TODO (2) IN PROGRESS (3) DONE");
                    var input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        board.ToDo.Add(new Card(board.ToDo[i].Title, board.ToDo[i].Content, board.ToDo[i].PersonId, board.ToDo[i].Size));
                        board.ToDo.Remove(board.ToDo[i]);
                    }
                    else if (input == 2)
                    {
                        board.InProgress.Add(new Card(board.ToDo[i].Title, board.ToDo[i].Content, board.ToDo[i].PersonId, board.ToDo[i].Size));
                        board.ToDo.Remove(board.ToDo[i]);
                    }
                    else if (input == 3)
                    {
                        board.Done.Add(new Card(board.ToDo[i].Title, board.ToDo[i].Content, board.ToDo[i].PersonId, board.ToDo[i].Size));
                        board.ToDo.Remove(board.ToDo[i]);
                    }
                    else
                    {
                        Console.WriteLine("You made a wrong choice!");
                    }

                    counter++;
                }
            }
            for (int i = 0; i < inProgressList.Count; i++)
            {
                if (inProgressList[i].Title.ToLower() == title.ToLower())
                {
                    var personName = persons.FirstOrDefault(x => x.Id == board.InProgress[i].PersonId)?.Name;
                    Console.WriteLine("Title: " + board.InProgress[i].Title + "\nContent: " + board.InProgress[i].Content + "\nPerson: " + personName + "\nSize: " + board.InProgress[i].Size + "\nLine: In Progress" + "\nPlease select the Line you want to move: (1) TODO (2) IN PROGRESS (3) DONE");
                    var input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        board.ToDo.Add(new Card(board.InProgress[i].Title, board.InProgress[i].Content, board.InProgress[i].PersonId, board.InProgress[i].Size));
                        board.InProgress.Remove(board.InProgress[i]);
                    }
                    else if (input == 2)
                    {
                        board.InProgress.Add(new Card(board.InProgress[i].Title, board.InProgress[i].Content, board.InProgress[i].PersonId, board.InProgress[i].Size));
                        board.InProgress.Remove(board.InProgress[i]);
                    }
                    else if (input == 3)
                    {
                        board.Done.Add(new Card(board.InProgress[i].Title, board.InProgress[i].Content, board.InProgress[i].PersonId, board.InProgress[i].Size));
                        board.InProgress.Remove(board.InProgress[i]);
                    }
                    else
                    {
                        Console.WriteLine("You made a wrong choice!");
                    }
                    
                    counter++;
                }
            }
            for (int i = 0; i < doneList.Count; i++)
            {
                if (doneList[i].Title.ToLower() == title.ToLower())
                {
                    var personName = persons.FirstOrDefault(x => x.Id == board.Done[i].PersonId)?.Name;
                    Console.WriteLine("Title: " + board.Done[i].Title + "\nContent: " + board.Done[i].Content + "\nPerson: " + personName + "\nSize: " + board.Done[i].Size + "\nLine: Done" + "\nPlease select the Line you want to move: (1) TODO (2) IN PROGRESS (3) DONE");
                    var input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        board.ToDo.Add(new Card(board.Done[i].Title, board.Done[i].Content, board.Done[i].PersonId, board.Done[i].Size));
                        board.Done.Remove(board.Done[i]);
                    }
                    else if (input == 2)
                    {
                        board.InProgress.Add(new Card(board.Done[i].Title, board.Done[i].Content, board.Done[i].PersonId, board.Done[i].Size));
                        board.Done.Remove(board.Done[i]);
                    }
                    else if (input == 3)
                    {
                        board.Done.Add(new Card(board.Done[i].Title, board.Done[i].Content, board.Done[i].PersonId, board.Done[i].Size));
                        board.Done.Remove(board.Done[i]);
                    }
                    else
                    {
                        Console.WriteLine("You made a wrong choice!");
                    }
                    
                    counter++;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("The card suitable for the criteria you are looking for could not be found on the board. Please make a choice.\n* To terminate the deletion : (1)\n* To try again: (2)");
                var input = int.Parse(Console.ReadLine());
                if (input == 1)
                {

                }
                else if (input == 2)
                {
                    MoveCard();
                }
            }
        }
        public void ListBoard()
        {
            Console.WriteLine("ToDo Line\n**************");
            foreach (var item in board.ToDo)
            {
                var personName = persons.FirstOrDefault(x => x.Id == item.PersonId)?.Name;
                Console.WriteLine("Başlık: " + item.Title + "\nİçerik: " + item.Content + "\nAtanan Kişi: " + personName + "\nBüyüklük: " + item.Size + "\n-" );
            }
            Console.WriteLine("In Progress Line\n**************");
            foreach (var item in board.InProgress)
            {
                var personName = persons.FirstOrDefault(x => x.Id == item.PersonId)?.Name;
                Console.WriteLine("Başlık: " + item.Title + "\nİçerik: " + item.Content + "\nAtanan Kişi: " + personName + "\nBüyüklük: " + item.Size + "\n-");
            }
            Console.WriteLine("Done Line\n**************");
            foreach (var item in board.Done)
            {
                var personName = persons.FirstOrDefault(x => x.Id == item.PersonId)?.Name;
                Console.WriteLine("Başlık: " + item.Title + "\nİçerik: " + item.Content + "\nAtanan Kişi: " + personName + "\nBüyüklük: " + item.Size + "\n-");
            }
        }
    }
}
