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

        // ref  out 사용법.
        static void TestRef1() {
            BaseCode b = new BaseCode();
            
            int num = 1;
            b.AddRef(ref num);
            Console.WriteLine("ref number:" + num);

            int num2 = 1;
            b.Add(num2);
            Console.WriteLine("ref number2:" + num2);

            //
            string f1, f2;
            b.Split("AAAAAAA BBBBBB CCCCCCCC", out f1, out f2);
            Console.WriteLine(f1); // AAA... BB..
            Console.WriteLine(f2); // CC..

            // params 수정자
            int sum = b.Sum(10, 20, 30, 40);
            Console.WriteLine("sum:" + sum);

            // 
            b.Foo(1);       // 1, 0 
            b.Foo(1, y: 2);     // 1. 2
            //b.Foo(x: 1, 2);     // 컴파일 오류
        }

        //
        void Split(string name, out string fName, out string lastName) {
            int i = name.LastIndexOf(' ');
            fName = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }

        int Sum(params int[] arr) {
            int sum = 0;
            foreach (var a in arr) {
                sum += a;
            }
            return sum;
        }

        void Foo(int x = 0, int y = 0) {
            Console.WriteLine(x + ", " + y);
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
