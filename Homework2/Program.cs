using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {   
            //ACOUNTING
            Console.WriteLine("Enter your grade percentage for Accounting (i.e. 94) >>");
            string answer1 = Console.ReadLine();
            double AccountingGrade;

            if (double.TryParse(answer1, out AccountingGrade) == false)
            {
                Console.WriteLine($"Sorry, {answer1} that you have entered is written incorrectly");
                Environment.Exit(-1);
            }
            AccountingGrade /= 100;

            //MARKETING
            Console.WriteLine("Enter your grade percentage for Marketing >>");
            string answer2 = Console.ReadLine();
            double marketingGrade;

            if (double.TryParse(answer2, out marketingGrade) == false)
            {
                Console.WriteLine($"Sorry, {answer2} that you have entered is written incorrectly");
                Environment.Exit(-2);
            }
            marketingGrade /= 100;

            //ECONOMICS
            Console.WriteLine("Enter your grade percentage for Economics >>");
            string answer3 = Console.ReadLine();
            double economicsGrade;

            if (double.TryParse(answer3, out economicsGrade) == false)
            {
                Console.WriteLine($"Sorry, {answer3} that you have entered is written incorrectly");
                Environment.Exit(-3);
            }
            economicsGrade /= 100;

            //MIS
            Console.WriteLine("Enter your grade percentage for MIS >>");
            string answer4 = Console.ReadLine();
            double MISGrade;

            if (double.TryParse(answer4, out MISGrade) == false)
            {
                Console.WriteLine($"Sorry, {answer4} that you have entered is written incorrectly");
                Environment.Exit(-4);
            }
            MISGrade /= 100;

            char accountingLetterGrade, marketingLetterGrade, economicsLetterGrade, MISLetterGrade;
            double totalpointsearned = 0, gpa = 0;
            const int TOTAL_CREDITS_ATTEMPTED = 12; //4 courses x 3 credit hours == 12

            //ACCOUNTINGGRADE
            if (AccountingGrade >= .9)
            {
                accountingLetterGrade = 'A';
                totalpointsearned += 4;
            }
            else if (AccountingGrade >= .8)
            {
                accountingLetterGrade = 'B';
                totalpointsearned += 3;
            }
            else if (AccountingGrade >= .7)
            {
                accountingLetterGrade = 'C';
                totalpointsearned += 2;
            }
            else if (AccountingGrade >= .6)
            {
                accountingLetterGrade = 'D';
                totalpointsearned += 1;
            }
            else
            {
                accountingLetterGrade = 'F';
                totalpointsearned += 0; //this one is not necessary

            }
            //MARKETINGGRADE
            if (marketingGrade >= .9)
            {
                marketingLetterGrade = 'A';
                totalpointsearned += 4;

            }
            else if (marketingGrade >= .8)
            {
                marketingLetterGrade = 'B';
                totalpointsearned += 3;

            }
            else if (marketingGrade >= .7)
            {
                marketingLetterGrade = 'C';
                totalpointsearned += 2;

            }
            else if (marketingGrade >= .6)
            {
                marketingLetterGrade = 'D';
                totalpointsearned += 1;

            }
            else
            {
                marketingLetterGrade = 'F';
            }
            //ECONOMICSGRADE
            if (economicsGrade >= .9)
            {
                economicsLetterGrade = 'A';
                totalpointsearned += 4;

            }
            else if (economicsGrade >= .8)
            {
                economicsLetterGrade = 'B';
                totalpointsearned += 3;

            }
            else if (economicsGrade >= .7)
            {
                economicsLetterGrade = 'C';
                totalpointsearned += 2;

            }
            else if (economicsGrade >= .6)
            {
                economicsLetterGrade = 'D';
                totalpointsearned += 1;

            }
            else
            {
                economicsLetterGrade = 'F';
            }
            //MISGRADE
            if (MISGrade >= .9)
            {
                MISLetterGrade = 'A';
                totalpointsearned += 4;

            }
            else if (MISGrade >= .8)
            {
                MISLetterGrade = 'B';
                totalpointsearned += 3;

            }
            else if (MISGrade >= .7)
            {
                MISLetterGrade = 'C';
                totalpointsearned += 2;

            }
            else if (MISGrade >= .6)
            {
                MISLetterGrade = 'D';
                totalpointsearned += 1;

            }
            else
            {
                MISLetterGrade = 'F';
            }
            Console.WriteLine();
            Console.WriteLine($"Your letter grade for Accounting is an {accountingLetterGrade}");
            Console.WriteLine($"Your letter grade for Marketing is an {marketingLetterGrade}");
            Console.WriteLine($"Your letter grade for Economics is an {economicsLetterGrade}");
            Console.WriteLine($"Your letter grade for MIS is an {MISLetterGrade}");

            //forgot to multiply the total points earned by the number of credit hours for the course so
            //we just devided by 3 (credit hours per course)
            gpa = totalpointsearned / (TOTAL_CREDITS_ATTEMPTED / 3);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine($"Your GPA is {gpa.ToString("N2")} this semester!");


            }
        }
    }

