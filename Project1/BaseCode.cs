using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JKTest.Code
{
    class BaseCode
    {
        //
        static void Main(string[] args) {
            //
            StartLog();

            //ref keyword Test
            TestRef1();
        
        }

        static void TestRef1() {
            BaseCode b = new BaseCode();
            
            int num = 1;
            b.AddRef(ref num);
            Console.WriteLine("ref number:" + num);

            int num2 = 1;
            b.Add(num2);
            Console.WriteLine("ref number2:" + num2);

        }


        static void StartLog() {

            Console.WriteLine("================ start ==========================");

        }

        void RefTest() {


        }

        void AddRef(ref int num) {
            num = num + 100;
        }

        void Add(int num) {
            num = num + 100;
        }


    }
}
