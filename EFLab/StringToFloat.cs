using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLab_3a
{
    class StringToFloat
    {
        public static float StringConverter()
        {
            Console.WriteLine("Enter a number");
            int inputNumber;
            string inputText = Console.ReadLine();
            bool isNumber = int.TryParse(inputText, out inputNumber);
            float inputSum = inputNumber * 12;
            return inputSum;
        }
    }
}
