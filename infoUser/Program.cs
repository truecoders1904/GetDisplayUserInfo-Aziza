using System;

namespace infoUser
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();              user.FirstName = user.AnswerQuestion("What's your first name?");              user.LastName = user.AnswerQuestion("What's your last name?");              user.FavAnimal = user.AnswerQuestion("What's your favorite animal?");              user.FavColor = user.AnswerQuestion("What's your favorite color?");              user.FavNumber = user.AnswerQuestionWithInteger("What's your favorite number?");              Console.WriteLine($"So you are { user.FirstName} { user.LastName} ");              Console.WriteLine($"Your spirit animal is a { user.FavAnimal}! ");              Console.WriteLine($"Your favorite color is { user.FavColor}");              Console.WriteLine($"And your lucky number is { user.FavNumber}");
        }
    }   
}
