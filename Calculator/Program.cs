using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("42*47=1_74", 9);
            Test("4_*47=1974", 2);
            Test("42*_7=1974", 4);
            Test("42*_47=1974", -1);
            Test("4_*46=1974", -1);
            Test("2*12_=247", -1);
        }
        static void Test(string equation, int expectedAnswer)
        {
            int calculatedAnswer = FindMissingNumber(equation);
            string passOrFails = calculatedAnswer == expectedAnswer ? "PASS" : "FAIL";
            Console.WriteLine(equation + " " + passOrFails+" calculated answer was " + calculatedAnswer.ToString());
        }
        static int FindMissingNumber(string equation)
        {
            try
            {
                var terms = equation.Split(new Char[] { '*', '=' });
                int result = -1;
                if (terms[0].Contains('_'))
                {
                    result = MissingNumberIn1stTerm(terms);
                }

                else if (terms[1].Contains('_'))
                {
                    result = MissingNumberIn2ndTerm(terms);
                }

                else if (terms[2].Contains('_'))
                {
                    result = MissingNumberIn3rdTerm(terms);
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }
        static int MissingNumberIn2ndTerm(string[] terms)
        {

            int firstNumber = int.Parse(terms[0]);
            int thirdNumber = int.Parse(terms[2]);
            int missingNumber = -1;
            if (thirdNumber % firstNumber == 0 )
            {
                int secondNumber = thirdNumber / firstNumber;
                missingNumber = CompareAndReturnMissingNumber(secondNumber.ToString(), terms[1]); 
            }
            return missingNumber;
        }

        private static int CompareAndReturnMissingNumber(string answer, string term)
        {
            int pos = term.IndexOf('_');
            term=term.Replace('_', answer[pos]);
            if (term == answer)
            {
                return int.Parse(answer[pos].ToString());
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
            int missingNumber = -1;
            if (thirdNumber % secondNumber == 0)
            {
                int firstNumber = thirdNumber / secondNumber;
                missingNumber = CompareAndReturnMissingNumber(firstNumber.ToString(), terms[0]);
            }
            return missingNumber;
        }
        static int MissingNumberIn3rdTerm(string[] terms)
        {

            int secondNumber = int.Parse(terms[1]);
            int firstNumber = int.Parse(terms[0]);
            int thirdNumber = firstNumber * secondNumber;
            return CompareAndReturnMissingNumber(thirdNumber.ToString(), terms[2]);
        }
    }
}