namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var favoriteSubject = Console.ReadLine();

            switch (favoriteSubject)
                {
                case "Mathematics":
                    Console.WriteLine("Wow, Mathematics is fun with numbers");
                    break;
                case "English":
                    Console.WriteLine("English is wordy and fun!");
                    break;
                case "Science":
                    Console.WriteLine("Science is so cool");
                    break;
                case "Arts":
                    Console.WriteLine("Arts is so rich");
                    break;
                case "Kiswahili":
                    Console.WriteLine("Kiswahili sanifu ni muhimu");
                    break;
                default:
                    Console.WriteLine("I have not heard of this subject");
                    break;


            }
        }
    }
}