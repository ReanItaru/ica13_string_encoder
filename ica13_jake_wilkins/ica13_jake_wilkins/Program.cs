using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ica13_jake_wilkins
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            string askReRun;            //input from user if they would like to run again
            string reRun = "yes";       //converts input into proper form so random capitalzation doesn't matter
            string encode = "";         //input string from user
            string encoded = "";        //final output


            //title
            Console.WriteLine("\t\t\tString Encoder");

            //input string from user
            do
            {
                Console.Write("\nEnter the string to encode: ");
                encode = Console.ReadLine();

                //encode string, #'s + 10 unicode value, char -1 letter, CHAR +1 letter, whitespace = *, others remain same
                foreach(char ch in encode)
                {
                    //char.IsWhiteSpace(encode,ch);
                    //encoded = encode.Replace(char.IsWhiteSpace(ch),'*');
                    //Console.WriteLine("Encoded string: {0}", encoded);
                }

                //display newly encoded string
                Console.WriteLine("Encoded string: {0}", encoded);
                //ask if user would like to encode again, works on upper and lower 'yes', exit on anything else
                Console.Write("\nEncode another string? yes or no: ");
                askReRun = Console.ReadLine();
                reRun = askReRun.ToLower();

            } while (reRun == "yes");

            //temporary pause to read, REMOVE BEFORE SUBMITTING
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
