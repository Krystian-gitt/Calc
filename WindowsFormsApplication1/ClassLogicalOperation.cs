using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class ClassLogicalOperation 
    {


        /// <summary>
        /// Method to add
        /// </summary>
        /// <param name="pierwszaLicz">First number</param>
        /// <param name="drugaLicz">Second number</param>
        /// <returns></returns>
       
        public long Sum(long firstNum, long secondNum)
        {   
            return firstNum + secondNum;
        }

        /// <summary>
        /// Substraction method 
        /// </summary>
        /// <param name="firstNum">First number</param>
        /// <param name="secondNum">Second number</param>
        /// <returns></returns>
        public long Minus(long firstNum, long secondNum)
        {
            return firstNum - secondNum;
        }

        /// <summary>
        /// Multiplication method
        /// </summary>
        /// <param name="firstNum">First number</param>
        /// <param name="secondNum">Second number</param>
        /// <returns></returns>
        public long Multiply(long firstNum, long secondNum)
        {
            return firstNum * secondNum;
        }

        /// <summary>
        /// Dividing method
        /// </summary>
        /// <param name="firstNum">First number</param>
        /// <param name="secondNum">Second number</param>
        /// <returns></returns>
        public double Divide(double firstNum, double secondNum)
        {
            return firstNum / secondNum;

        }
        /// <summary>
        /// Square root method
        /// </summary>
        /// <param name="firstNum">First number</param>
        /// <returns></returns>
        public double SquareRoot(double firstNum)
        {
            return Math.Sqrt(firstNum);
        }
    }
}
