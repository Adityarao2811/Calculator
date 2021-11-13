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
                Missingnumberin1stterm(terms);
            }

            else if (terms[1].Contains('_'))
            {
                Missingnumberin2ndterm(terms);
            }

            else if (terms[2].Contains('_'))
            {
                Missingnumberin3rdterm(terms);
            }
        }
        static void Missingnumberin2ndterm(string[] terms)
        {

            int firstNumber = int.Parse(terms[0]);
            int thirdnumber = int.Parse(terms[2]);
            int secondnumber = thirdnumber / firstNumber;
            Console.WriteLine(secondnumber);
        }
        static void Missingnumberin1stterm(string[] terms)
        {

            int secondNumber = int.Parse(terms[1]);
            int thirdnumber = int.Parse(terms[2]);
            int firstnumber = thirdnumber / secondNumber;
            Console.WriteLine(firstnumber);
        }
        static void Missingnumberin3rdterm(string[] terms)
        {

            int secondNumber = int.Parse(terms[1]);
            int firstnumber = int.Parse(terms[0]);
            int thirdnumber = firstnumber * secondNumber;
            Console.WriteLine(thirdnumber);
        }
    }
}