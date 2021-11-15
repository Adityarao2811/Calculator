using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string equation = "_51*10=4500";
            try
            {
                var terms = equation.Split(new Char[] { '*', '=' });
                int result = -1;
                if (terms[0].Contains('_'))
                {
                    result=MissingNumberIn1stTerm(terms);
                }

                else if (terms[1].Contains('_'))
                {
                   result= MissingNumberIn2ndTerm(terms);
                }

                else if (terms[2].Contains('_'))
                {
                    result = MissingNumberIn3rdTerm(terms);
                }
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static int MissingNumberIn2ndTerm(string[] terms)
        {

            int firstNumber = int.Parse(terms[0]);
            int thirdNumber = int.Parse(terms[2]);
            int secondNumber = thirdNumber / firstNumber;
            return PrintMissingNumber(secondNumber.ToString(), terms[1]);
        }

        private static int PrintMissingNumber(string answer, string term)
        {
            int pos = term.IndexOf('_');
            term.Replace('_', answer[pos]);
            if (term == answer)
            {
                return answer[pos];
            }
            else
            {
                return -1;
            }
        }

        static int MissingNumberIn1stTerm(string[] terms)
        {

            int secondNumber = int.Parse(terms[1]);
            int thirdNumber = int.Parse(terms[2]);
            int firstNumber = thirdNumber / secondNumber;
            Console.WriteLine(firstNumber);
            int missingNumber=PrintMissingNumber(firstNumber.ToString(), terms[0]);
            return missingNumber;
        }
        static int MissingNumberIn3rdTerm(string[] terms)
        {

            int secondNumber = int.Parse(terms[1]);
            int firstNumber = int.Parse(terms[0]);
            int thirdNumber = firstNumber * secondNumber;
            Console.WriteLine(thirdNumber);
            return PrintMissingNumber(thirdNumber.ToString(), terms[2]);
        }
    }
}