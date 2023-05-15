namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            var answer = Console.ReadLine();

            switch (answer)
            {
                case "Math":
                    Console.WriteLine("Math is the worst subject");
                    break;
                case "math":
                    Console.WriteLine("math is the worst subject");
                    break;
                case "Science":
                    Console.WriteLine("Science is a great subject");
                    break;
                case "science":
                    Console.WriteLine("science is a great subject");
                    break;
                case "English":
                    Console.WriteLine("I enjoy English as well");
                    break;
                case "english":
                    Console.WriteLine("english is awesome!");
                    break;
                case "History":
                    Console.WriteLine("History was my favorite too!");
                    break;
                case "history":
                    Console.WriteLine("history was my favorite too");
                    break;
                default:
                    Console.WriteLine("That is not a viable answer");
                    break;

            }
        }
    }
}