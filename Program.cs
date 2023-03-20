namespace Algorithm_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GOAL: Write a method which takes in two strings as input which produces an interlaced string of both inputs.
            //For example: the inputs 'cat' and 'dog' will produce the following output 'cdaotg'.
            //Note: Leftover characters from a longer input will simply be appended to the end of the resultant string.

            //Boolean trigger to continue loop, if user wishes.
            bool goOn = true;

            //Creates instance of StringLacer class
            StringLacer s = new StringLacer();

            while (goOn)
            {
                //Prompts user for input to be used.
                Console.WriteLine("Please enter the first string that you'd like to interlace: \n");

                string string1 = Console.ReadLine();

                Console.WriteLine("\nPlease enter the second string that you'd like to interlace: \n");

                string string2 = Console.ReadLine();

                //Calls StringLacer class's method in order to weave strings together.
                string interLaced = s.StringInterLacer(string1, string2);

                //Displays output to the user.
                Console.WriteLine($"\nYour output is: {interLaced}\n");

                //Calls helper method to ask the user to continue.
                goOn = AskToGoOn();
            }

        }

        public static bool AskToGoOn()
        {
            Console.WriteLine("Would you like to interlace two more strings? Please enter yes (Y) or no (N).\n");

            string input = Console.ReadLine().ToLower();

            if (input == "Y" || input == "y" || input == "yes")
            {
                Console.WriteLine("\nAlright! Let's create a new string!\n");
                return true;
            }
            else if (input == "N" || input == "n" || input == "no")
            {
                Console.WriteLine("\nGoodbye!\n");
                return false;
            }
            else
            {
                Console.WriteLine("\nI'm sorry. I didn't understand that. Please try again.\n");
                return AskToGoOn();
            }
        }

    }
}