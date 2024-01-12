using System.Diagnostics.Metrics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        StringBuilder stringBuilder = new StringBuilder();
        int userInteger = default;
        int counter = default;
        string userConsoleInput = string.Empty;

        Console.WriteLine("To start building a pyramid, enter any integer : ");

        userConsoleInput = Console.ReadLine();


        if (int.TryParse(userConsoleInput, out userInteger))
        {
            for (int i = 1; i <= userInteger; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    if (counter == userInteger)
                    {
                        break;
                    }
                    else
                    {
                        counter++;

                    }
                    stringBuilder.Append(counter + " ");
                }
                if (counter == userInteger)
                {
                    break;
                }
                else
                {
                    stringBuilder.Append("\n");
                }

            }
            Console.WriteLine(stringBuilder);
        }
        else
        {
            Console.WriteLine("Input is not an integer");

        }



    }
}
