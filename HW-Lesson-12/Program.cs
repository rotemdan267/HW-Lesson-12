using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q-6

            DateTime dt = new DateTime();
            
            Quotation q = new Quotation("hgh", dt, 7);
            for (int i = 0; i < q.SumLines.Length; i++)
            {
                q.SumLines[i] = i + 1;
            }
            double[] arr = q.SumLines;
            double sum = 0;
            for (int i = 0; i < q.SumLines.Length; i++)
            {
                sum += q.SumLines[i];
            }
            for (int i = 0; i <arr.Length; i++)
            {
                arr[i] = i + 2;
            }


            q.ChangeMainDetails("dsdss", dt);

            #endregion

            Console.ReadLine();
        }
    }
}
