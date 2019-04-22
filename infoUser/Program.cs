using System;

namespace infoUser
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();              Console.WriteLine("Hey, let me ask you a little about yourself");

            user.FirstName = user.AnswerQuestion("What's your first name?");              user.LastName = user.AnswerQuestion("What's your last name?");              user.FavAnimal = user.AnswerQuestion("What's your favorite animal?");              user.FavColor = user.AnswerQuestion("What's your favorite color?");              user.FavNumber = user.AnswerQuestionWithInteger("What's your favorite number?");              Console.WriteLine($"So you are { user.FirstName} { user.LastName} ");              Console.WriteLine($"Your spirit animal is a { user.FavAnimal}! ");

            Console.Write($"And your lucky number is");


            if (user.FavNumber > 10 )
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($" { user.FavNumber}");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else if (user.FavNumber < 5)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" { user.FavNumber}");
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }
    }   
}
