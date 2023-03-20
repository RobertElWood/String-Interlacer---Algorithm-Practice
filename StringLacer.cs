using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm_Practice
{
    internal class StringLacer
    {
        public string StringInterLacer(string input1, string input2)
        {

            //Output variable to store data.
            string output = "";

            //If first input string is longer, will append remainder of input1.
            if (input1.Length > input2.Length)
            {
                for (int i = 0; i < input2.Length; i++)
                {
                    output += input1[i];
                    output += input2[i];
                }

                output += input1.Substring(input2.Length);

            }
            //If second input string is longer, will append remainder of input2.
            else if (input2.Length > input1.Length)
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    output += input1[i];
                    output += input2[i];
                }

                output += input2.Substring(input1.Length);

            }
            //If input length is equal, will simply iterate through input1. 
            //Length, in this case, is inconsequential.
            else if (input2.Length == input1.Length)
            {
                for (int i = 0; i < input1.Length; i++)
                {
                    output += input1[i];
                    output += input2[i];
                }
            }

            return output;

        }
    }
}
