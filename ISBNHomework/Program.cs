using System;

namespace ISBNHomework // Note: actual namespace depends on the project name.
{
    internal class ISBNHomework
    {
        static void Main()
        {
            //string ISBNMissing = Console.ReadLine();
            Console.Write(FindMissingInt("15688?111X"));
        }

        static int FindMissingInt(string ISBN)
        {
            int total = 0;
            int pos = 1;
            int cor;

            for (int i = 0; i < ISBN.Length; i++)
            {
                if (Char.IsDigit(ISBN[i]))
                {
                    total += (ISBN.Length - i) *  (ISBN[i] - '0');
                }

                else if (ISBN[i] == 'X') { total += 10; }
                
                else if (ISBN[i] == '?') { pos = 10 - i; }
                
            }

            if (11-total >= 0)
            {
                cor = (11 - total) / pos;
            }

            else
            {
                cor = ((11 - total) + 11 * (int)MathF.Ceiling((float)(Math.Abs(11-total)) / 11)) / pos; 
                //find 11 - rest of numbers summed, adds the lowest multiple of 11 that makes this positive, divides by weight
            }
            
            return cor;
        }
    }
}

//QUESTION 1b) 3540678654 and 9514451570
//QUESTION 2b) 2301014525, 0201314525, 3401012525, 3200114525
