using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Linq;

//C# base
namespace JKTest
{

    // C# Base Test
    class UserTestA
    {
        // Main                                                                                                                                                                                                                    
        static void main(String[] args) {

            Dictionary<string, Action<TextWriter>> dic = new Dictionary<string, Action<TextWriter>>();

            dic.Add("Sample1", (writer) => { writer.WriteLine("I am sample1"); });

            Console.WriteLine("-----------start-----------------");

            var dic2 = new Dictionary<string, Action<TextWriter>>();
            dic2.Add("Sample2", (writer) => { writer.WriteLine("DDDDDDDDDDDDDDDDDDDDDDDDDDDDD"); });

            Console.WriteLine(dic2.Values);
            foreach (var item in dic.Values) {
                item(Console.Out); //
            }

            //Console.ReadLine();

            //
            UserTestA a = new UserTestA();
            a.testCode();
            string s = "Red";

            a.swtichTest(ref s);
            Console.WriteLine(s);
            var start = DateTime.Now;

            Console.WriteLine("소요시간:{0}", DateTime.Now);

            a.roopTest();
            //
            int[] array = { 0,1,2,3,4,5,6, -1, -2};
            // 오류 발생시 처리방법은 ?;
            Console.WriteLine(array.Where(c => c < 0).ElementAt(1));

            //
            var version = System.Environment.Version;
            Console.WriteLine("version: {0}, {1}", version, System.Environment.OSVersion);

            int[,] matrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++) {
                //
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    matrix[i, j] = i * 3 + j;
                }
            }

            //
            int[,] matrix2 = new int[,] {
                { 0,1,2},
                { 3,4,5},
                { 6,7,8}
            };

            var time = DateTime.Now;
            Console.WriteLine("{0}", time.ToShortDateString());
            Console.WriteLine("{0}", time.ToLongDateString());

            int[] arr = new int[3];
            //arr[3] = 100;

            // Test
            int number = 100;
            a.addMethod(number);
            Console.WriteLine(number);

            //
            a.refMethod(ref number);
            Console.WriteLine(number);

        }

        public void refMethod(ref int p) {
            p = p + 1;
        }

        public void addMethod(int p) {
            p = p + 1;
        }




        public void roopTest() {

            int[] a = { 0,1,2,3,4,5,6,7,8,9};
            foreach (var num in a) {
                Console.WriteLine( num );
            }
        }


        //
        public void testCode() {
            var a = 0;
            
            //= "StingType";
            var b = 100;

            var c = a + b;

            a = 1000;

            c = a + b;

            Console.WriteLine(c);


        }

        public void swtichTest(ref string color) {

            switch (color) {
                case "Red": color = "빨강"; break;
                case "Green": color = "초록"; break;
                case "Blue":color = "파랑"; break;
                default: color = "알 수 없는 색"; break;
            }
                    
        }


    }
}
