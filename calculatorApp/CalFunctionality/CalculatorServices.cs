using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorApp.CalFunctionality
{
    public class CalculatorServices
    {
        public static double Plus(double value,double lastValue)
        {
            return value+lastValue;
        }
        public static double Minus(double value, double lastValue)
        {
            return lastValue-value;
        }
        public static double Multiply(double value, double lastValue)
        {
            if (lastValue == 0)
            {
                return value;
            }
            return value*lastValue;
        }
        public static double Divide(double value, double lastValue)
        {
            if (lastValue == 0)
            {
                return value;
            }
            return lastValue/value;
        }
        public static double Modulas(double value, double lastValue)     
        {
            if(lastValue==0)
            {
                return value;
            }
            return lastValue%value;
        }
        public static double Equal(double value,double lastvalue,char sign)
        {
            switch (sign)
            {
                case '+':
                   lastvalue= Plus(value, lastvalue);
                    break;
                case '-':
                   lastvalue= Minus(value, lastvalue);
                    break;
                case 'X':
                    lastvalue = Multiply(value, lastvalue);
                    break;
                case '/':
                    lastvalue = Divide(value, lastvalue);
                    break;
                case '%':
                    lastvalue = Modulas(value, lastvalue);
                    break;
                
            }
           
            return lastvalue;
        }
        public double Clear(double value)
        {
            return value;
        }
        public static string SetTextToResultlabel(string currentnumber,string lastnumber)
        {
            if(lastnumber== null|| lastnumber== "0" )
            {
                return currentnumber;
            }
            return String.Concat(lastnumber,currentnumber);    
            
        }
    }
}
