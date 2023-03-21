using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class Program
    {
        public static void Main()
        {
            float numericGrade = 0;
            //string customTriangle;
            float correspondingLetterGrade ;

            Console.Write("\n\n");
            Console.Write("convert a numeric (float) grade into a corresponding letter grade \n");
            Console.Write("--------------------------------------------------------\n");
            Console.Write("This program only takes in positive integers greater than 0");
            Console.Write("\n\n");

            Console.WriteLine("Please Enter the numeric float grade between 0.0 and 100.00:");
            //object floate = null;
            while (!float.TryParse(Console.ReadLine(),out numericGrade))
            {
                Console.WriteLine("Please Enter a valid numeric value!");

            }

            correspondingLetterGrade= Grade.GradeConverter(numericGrade);

            Console.WriteLine(correspondingLetterGrade);
            Console.ReadLine();



        }
    }
}
