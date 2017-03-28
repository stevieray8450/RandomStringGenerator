using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomStringGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string randoString = "";
            Random randIndex = new Random();
            int randIndexNum;

            char[] charBank = new char[12];
            charBank[0] = '_';
            charBank[1] = 'b';
            charBank[2] = '?';
            charBank[3] = 'Z';
            charBank[4] = 'x';
            charBank[5] = 'B';
            charBank[6] = '3';
            charBank[7] = 'D';
            charBank[8] = '1';
            charBank[9] = '2';
            charBank[10] = '3';
            charBank[11] = '!';

            for (int i = 0; i < charBank.Length; i++)
            {
                randIndexNum = randIndex.Next(0, 11);
                randoString += charBank[randIndexNum];
            }

            Console.WriteLine(randoString);
        }
    }
}
