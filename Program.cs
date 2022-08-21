//Exercise 3
//Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
//A valid time should be between 00:00 and 23:59.
//If the time is valid, display "Ok"; otherwise, display "Invalid Time".
//If the user doesn't provide any values, consider it as Invalid time.



namespace CsharpFundamentals
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Please enter a time value in the 24-hour time format (e.g. 19:00).");

            var userInput = Console.ReadLine();
            var splitInput = userInput.Split(':');
            var valid = false;

            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Invalid Time");
                return;
            }
            else
            {
                for (int i = 0; i < splitInput.Length; i++)
                {
                    if (Convert.ToInt32(splitInput[0]) > 23 || Convert.ToInt32(splitInput[1]) > 59)
                    {
                        valid = false;
                    }
                    else
                    {
                        valid = true;
                    }
                }

                if (valid == true)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Invalid Time");
                }
            }
                
        }
    }
}
    