using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class Grade
    {
        public static float GradeConverter(float numericGrade)
        {
            //float numericGrade=0;
           float result;
            //Console.WriteLine("Please enter your grade out of 100");
            //Console.WriteLine("The corresponding Letter Grade is:");
            //Console.ReadLine();

            if (numericGrade>=80.0 && numericGrade<=100)
            {
               
                Console.WriteLine("The corresponding Letter Grade is:   A");
               //Console.ReadLine() ;
             


            }
            else if (numericGrade>=70.0 && numericGrade<=79.9)

            {
                Console.WriteLine("The corresponding Letter Grade is:   B");
            }
            else if (numericGrade>=60.0 && numericGrade<=69.9)

            {
                Console.WriteLine("The corresponding Letter Grade is:   C");
            }
            else if (numericGrade>=55.0 && numericGrade<=59.9)

            {
                Console.WriteLine("The corresponding Letter Grade is:   D");
            }
            else
            {
                Console.WriteLine("The corresponding Letter Grade is:   F");
            }
            return numericGrade;
        }
    }
}

    
