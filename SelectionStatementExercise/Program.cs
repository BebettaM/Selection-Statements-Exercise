namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)

        // Exercise 1
        {
            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("Can you guess my favorite number?");
            Console.WriteLine("What is the upper Limit for range of the number?");

            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(2, upperLimit);

            Console.WriteLine("Input your guess:");

            var guess = int.Parse(Console.ReadLine());

            if (guess > number)

            {
                Console.WriteLine("Sorry, your guess is too high!");
            }

            else if (guess < number)
            {
                Console.WriteLine("Your guess is too low! Sorry");
            }
            else
            {
                Console.WriteLine("You got it right!");
            }

    //Exercise 2

    Console.WriteLine("What is your favorite TV show?");

        var show = Console.ReadLine();

       switch (show)
            {
        case "Save by the bell":
            Console.WriteLine("Save by the bell is a great show");

        break;

        case "Friends":

          Console.WriteLine("Friends, that is great!");

        break;

        case "Office":
            Console.WriteLine("Office is a awsome show!");

        break;

        default:

            Console.WriteLine("I have seen that show before.");
         break;

            }
 

        }
    }
}

       
     
