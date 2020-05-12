using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    public class Calculator
    {
        // postfixExpression is a string in the following format: Element space Element space Element space ...
        public double EvaluatePostfix(string postfixExpression)
        {
            Stack<double> stack = new Stack<double>();
            string[] tokens = postfixExpression.Split(' ');
            for (int i = 0; i < tokens.Length; i++)
            {
                string token = tokens[i];
                if (double.TryParse(token, out double value))
                {
                    stack.Push(value);
                }
                else // This means we are processing an operator + - * /
                {
                    double operand2 = stack.Pop();
                    double operand1 = stack.Pop();
                    double result = EvalInfixExpression(token, operand2, operand1);
                    stack.Push(result);
                }
            }
            return stack.Pop();
        }

        private static double EvalInfixExpression(string token, double operand2, double operand1)
        {
            double result = 0;
            if (token == "+")
            {
                result = operand1 + operand2;
            }
            else if (token == "*")
            {
                result = operand1 * operand2;
            }

            return result;
        }
    }
}


