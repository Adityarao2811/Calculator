using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string equation = "450*10=4_00";
            var terms = equation.Split(new Char[] { '*', '=' });
            if (terms[0].Contains('_'))
            {
                MissingNumberIn1stTerm(terms);
            }

            else if (terms[1].Contains('_'))
            {
                MissingNumberIn2ndTerm(terms);
            }

            else if (terms[2].Contains('_'))
            {
                MissingNumberIn3rdTerm(terms);
            }
        }
        static void MissingNumberIn2ndTerm(string[] terms)
        {

            int firstNumber = int.Parse(terms[0]);
            int thirdNumber = int.Parse(terms[2]);
            int secondNumber = thirdNumber / firstNumber;
            Console.WriteLine(secondNumber);
        }
        static void MissingNumberIn1stTerm(string[] terms)
        {

            int secondNumber = int.Parse(terms[1]);
            int thirdNumber = int.Parse(terms[2]);
            int firstNumber = thirdNumber / secondNumber;
            Console.WriteLine(firstNumber);
        }
        static void MissingNumberIn3rdTerm(string[] terms)
        {

            int secondNumber = int.Parse(terms[1]);
            int firstNumber = int.Parse(terms[0]);
            int thirdNumber = firstNumber * secondNumber;
            Console.WriteLine(thirdNumber);
        }
    }
}