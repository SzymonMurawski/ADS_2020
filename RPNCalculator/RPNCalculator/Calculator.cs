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
                if(double.TryParse(token, out double value))
                {
                    stack.Push(value);
                }
            }
            return stack.Pop();
        }
    }
}
