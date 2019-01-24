using System;
namespace Lab10
{
    public class Validator
    {
        public static double ValidateInput(string input)
        {
            double validInput;
            if(double.TryParse(input,out validInput) == true) 
            {
                return validInput;
            }
            else
            {
                return -1;
            }
        }
    }
}
