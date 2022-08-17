using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace Lab_Excer
{
    [TestClass]
    public class MyCalcTest
    {
        
        
        [DataTestMethod]
        [DataRow (20,10,30)]
        [DataRow (20,18,38)]
        [DataRow (32,16,48)]
        public void TestDataAddMethod(double op1,double op2,double expresult)
        {
            double actualresult=MyCalc.Add(op1,op2);
            Assert.AreEqual(expresult,actualresult,"Add test case is failed");
        }
        [DataTestMethod]
        [DataRow (20,10,12)]
        [DataRow (20,18,28)]
        [DataRow (32,16,38)]
        public void NegativeTestDataAddMethod(double op1,double op2,double expresult)
        {
            double actualresult=MyCalc.Add(op1,op2);
            Assert.AreNotEqual(expresult,actualresult,"Add test case is failed");
        }
       [DataTestMethod]
        [DataRow (20,10,10)]
        [DataRow (26,10,16)]
        [DataRow (28,08,20)]
        public void TestDataSubMethod(double op1,double op2,double expresult)
        {
            double actualresult=MyCalc.Sub(op1,op2);
            Assert.AreEqual(expresult,actualresult,"Add test case is failed");
        }
        [DataTestMethod]
        [DataRow (20,10,05)]
        [DataRow (18,12,12)]
        [DataRow (38,12,16)]
        public void NegativeTestDataSubMethod(double op1,double op2,double expresult)
        {
            double actualresult=MyCalc.Sub(op1,op2);
            Assert.AreNotEqual(expresult,actualresult,"Sub test case is failed");
        }
        [DataTestMethod]
        [DataRow (20,10,200)]
        [DataRow (18,10,180)]
        [DataRow (20,12,240)]
        public void TestDataMulMethod(double op1,double op2,double expresult)
        {
            double actualresult=MyCalc.Mul(op1,op2);
            Assert.AreEqual(expresult,actualresult,"Mul test case is failed");
        }
       [DataTestMethod]
        [DataRow (20,10,20)]
        [DataRow (18,10,18)]
        [DataRow (20,10,10)]
        public void NegativeTestDataMulMethod(double op1,double op2,double expresult)
        {
            double actualresult=MyCalc.Mul(op1,op2);
            Assert.AreNotEqual(expresult,actualresult,"Mul test case is failed");
        }
        [DataTestMethod]
        [DataRow (20,10,2)]
        [DataRow (18,10,1.8)]
        [DataRow (28,7,4)]

        public void TestDataDivMethod(double op1,double op2,double expresult)
        {
            double actualresult=MyCalc.Div(op1,op2);
            Assert.AreEqual(expresult,actualresult,"Div test case is failed");
        }
        [DataTestMethod]
        [DataRow (20,10,5)]
        [DataRow (18,10,1)]
        [DataRow (28,17,5)]

        public void NegativeTestDataDivMethod(double op1,double op2,double expresult)
        {
            double actualresult=MyCalc.Div(op1,op2);
            Assert.AreNotEqual(expresult,actualresult,"Div test case is failed");
        }
        [DataTestMethod]
        [DataRow (2,2,4)]
        [DataRow (3,3,27)]
        [DataRow (4,3,64)]

        public void TestDataPowMethod(double op1,double op2,double expresult)
        {
            double actualresult=MyCalc.Pow(op1,op2);
            Assert.AreEqual(expresult,actualresult,"Pow test case is failed");
        }
        [DataTestMethod]
        [DataRow (20,10,5)]
        [DataRow (18,10,1)]
        [DataRow (28,17,5)]
        [DataRow (28,17,6)]

        public void NegativeTestDataPowMethod(double op1,double op2,double expresult)
        {
            double actualresult=MyCalc.Pow(op1,op2);
            Assert.AreNotEqual(expresult,actualresult,"Pow test case is failed");
        }
        
        
        
    }
}
