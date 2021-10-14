using System;

namespace HomeWork_02
{    
    struct ExampleStruct
    {

    }
        class Program
    {
        static void Main(string[] args)
        {
            #region implicit conversion
            //1
            byte number1 = 127;
            int number2 = number1 + 777;
            //2
            float number3 = -2.01f;
            double number4 = number3 - 1.88;
            //3
            long number5 = 4333222111;
            double number6 = number5 * 0.56;
            //4
            int number7 = 999;
            decimal number8 = number1 * number7;
            //5
            char symbol1 = 'C';
            char symbol2 = '#';
            int result = symbol1 + symbol2;
            #endregion

            #region explicit conversion
            //1
            int number9 = 910;
            byte number10 = (byte)number9;
            //2
            double number11 = -99.3342352352435245325235235;
            float number12 = (float)number11 / 555;
            //3
            byte number13 = 126;
            byte number14 = 1;
            byte result2 = (byte)(number13 + number14);
            //4
            decimal number15 = 10;
            int number16 = (int)number15 * 21;
            //5
            int number17 = 109;
            char result3 = (char)number17;
            #endregion

            #region boxing / unboxing
           
            //1
            int number18 = 777;
            object number19 = number18++; //boxing
            int number20 = (int)number19; //unboxing
            //2
            DateTime currentTime = new();
            object time = DateTime.Now; //boxing
            currentTime = (DateTime)time; //unboxing
            //3
            double number21 = 77.99;
            object number22 = number21--; //boxing
            double number23 = (double)number22; // unbooxing
            //4
            ExampleStruct example2 = new ExampleStruct();
            Object example3 = example2; //boxing
            ExampleStruct example4 = (ExampleStruct)example3; //unboxing
            //5
            byte number24 = 2;
            object number25 = number24++; //boxing
            byte number26 = (byte)number25; //unboxing

            #endregion
        }
    }
}
