using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Lesson_12
{
    class Quotation
    {
        public string CustomerName { get; private set; }
        public double[] SumLines { get; set; }
        public double DocSum 
        {
            get
            {
                double sum = 0;
                for (int i = 0; i < SumLines.Length; i++)
                {
                    sum += SumLines[i];
                }
                return sum;
            }
        }
        public DateTime ValidUntil { get; private set; }

        public Quotation(string customerName, DateTime validUntil, int numOfLines)
        {
            CustomerName = customerName;
            ValidUntil = validUntil;
            SumLines = new double[numOfLines];
        }

        public void ChangeMainDetails(string customerName, DateTime validUntil)
        {
            CustomerName = customerName;
            ValidUntil = validUntil;
        }
    }
}
