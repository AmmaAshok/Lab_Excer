using System;

namespace Lab_Excer
{
    public class MyCalc
    {
        public static double Add(double op1,double op2)

            {
                return op1+op2;
            }
       public static double Sub(double op1,double op2)

            {
                return op1-op2;
            }

            
    public static double Div(double op1,double op2)

            {
                return op1/op2;
            }
    public static double Mul(double op1,double op2)

            {
                return op1*op2;
            }
    
    public static double Pow(double op1,double op2)

               
            {
               double Pow=Math.Pow(op1,op2);
              return Pow;     
            } 


            
     
     public static int Power(int p1,int p2)
    {
        int p3=1;
        for (int i=p1; i<=p2;i++)
        { 
            p3=p3*p1;
        }
        return p3;
    }

          }
}