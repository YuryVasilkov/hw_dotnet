using System;

namespace HW._02.Types
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte
            sbyte n1 = 1;
            SByte n2 = 2;
            Console.WriteLine("The type name of variable n1 -- " + n1.GetType() + ", and variable n2 -- " + n2.GetType());
            //byte
            byte n3 = 3;
            Byte n4 = 4;
            Console.WriteLine("The type name of variable n3 -- " + n3.GetType() + ", and variable n4 -- " + n4.GetType());
            //short
            short n5 = 5;
            Int16 n6 = 6;
            Console.WriteLine("The type name of variable n5 -- " + n5.GetType() + ", and variable n6 -- " + n6.GetType());
            //ushort
            ushort n7 = 7;
            UInt16 n8 = 8;
            Console.WriteLine("The type name of variable n7 -- " + n7.GetType() + ", and variable n8 -- " + n8.GetType());
            //int
            int n9 = 9;
            Int32 n10 = 10;
            Console.WriteLine("The type name of variable n9 -- " + n9.GetType() + ", and variable n10 -- " + n10.GetType());
            //uint
            uint n11 = 11;
            UInt32 n12 = 12;
            Console.WriteLine("The type name of variable n11 -- " + n11.GetType() + ", and variable n12 -- " + n12.GetType());
            //long
            long n13 = 13;
            Int64 n14 = 14;
            Console.WriteLine("The type name of variable n13 -- " + n13.GetType() + ", and variable n14 -- " + n14.GetType());
            //ulong
            ulong n15 = 15;
            UInt64 n16 = 16;
            Console.WriteLine("The type name of variable n15 -- " + n15.GetType() + ", and variable n16 -- " + n16.GetType());
            //char
            char n17 = 'A';
            Char n18 = 'B';
            Console.WriteLine("The type name of variable n17 -- " + n17.GetType() + ", and variable n18 -- " + n18.GetType());
            //float
            float n19 = 19.9999f;
            Single n20 = 16.77777f;
            Console.WriteLine("The type name of variable n19 -- " + n19.GetType() + ", and variable n20 -- " + n20.GetType());
            //double
            double n21 = -19.9999;
            Double n22 = -16.77777;
            Console.WriteLine("The type name of variable n21 -- " + n21.GetType() + ", and variable n22 -- " + n22.GetType());
            //decimal
            decimal n23 = 23;
            Decimal n24 = 24;
            Console.WriteLine("The type name of variable n23 -- " + n23.GetType() + ", and variable n24 -- " + n24.GetType());
            //bool
            bool n25 = true;
            Boolean n26 = false;
            Console.WriteLine("The type name of variable n25 -- " + n25.GetType() + ", and variable n26 -- " + n26.GetType());
            //object
            object n27 = new object();
            Object n28 = new Object();
            Console.WriteLine("The type name of variable n27 -- " + n27.GetType() + ", and variable n28 -- " + n28.GetType());
            //string
            string n29 = "Hello";
            String n30 = " World!";
            Console.WriteLine("The type name of variable n29 -- " + n29.GetType() + ", and variable n30 -- " + n30.GetType());
        }
    }
}
