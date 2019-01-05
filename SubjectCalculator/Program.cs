using System;
namespace SubjectCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal english = 0;
            decimal maths = 0;
            decimal chemistry = 0;
            decimal physics = 0;
            decimal geography = 0;
            decimal economics = 0;
            decimal accounts = 0;
            decimal litInEnglish = 0;
            decimal totalScore = 0;
            decimal averageScore = 0;

            Console.WriteLine("Kindly enter your scores on the following subjects \n");
            Console.WriteLine("English: ");
            //english = Int32.Parse(Console.ReadLine());
            english = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Mathematics: ");
            maths = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Chemistry: ");
            chemistry = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Physics: ");
            physics = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Geography: ");
            geography = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Economics: ");
            economics = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Accounts: ");
            accounts = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Lit in English: ");
            litInEnglish = Convert.ToDecimal(Console.ReadLine());

            totalScore = english + maths + chemistry + physics + geography + economics + accounts + litInEnglish;
            averageScore = totalScore / 8;

            if (averageScore >= 70 && averageScore <= 100) {
                Console.WriteLine("Your score is A, " + "with an average value of " +averageScore);
            } else if (averageScore >= 60 && averageScore <= 69) {
                Console.WriteLine("Your score is B, " + "with an average value of " + averageScore);
            } else if (averageScore >= 50 && averageScore <= 59) {
                Console.WriteLine("Your score is C, " + "with an average value of " + averageScore);
            } else if (averageScore >= 40 && averageScore <= 49) {
                Console.WriteLine("Your score is D, " + "with an average value of " + averageScore);
            } else {
               Console.WriteLine("Your score is F, " + "with an average value of " + averageScore);
            }
           
            Console.ReadLine();
        }
    }
}
