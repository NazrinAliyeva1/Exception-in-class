using System.Reflection;
using System.Security.Principal;

namespace Exception_in_class_learn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test test = new Test();
            ////test[0] = -1;
            ///*  test[11] = 1;*/
            ////test.Arr[0] = 1;
            //test[0] = 9;
            //test[1] = 8;
            //test[2] = 7;
            //test[3] = 6;
            //test[4] = -9;
            //for(int i = 0; i<test.Length; i++)
            //{
            //    Console.WriteLine(test[i]);
            //}

            //Test t = new Test();
            //foreach (var prop in typeof(Test).GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance ))
            //{
            //    //Console.WriteLine(prop.Name); //1

            //    //prop.SetValue(t, 40);
            //    //Console.WriteLine(prop.GetValue(t)); //2

            //    Console.WriteLine(prop.Name);
            //}

            Test b = new Test();
            foreach(var prop in typeof(Test).GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
            {
                //Console.WriteLine(prop.Name);
                prop.SetValue(b, 98);
                Console.WriteLine(prop.GetValue(b));
            }


        }



        class Test
        {
            //private int[] Arr { get; }
            private int A { get; set; } = 6;

            //public int Length => Arr.Length;
            //public int this[int i]
            //{
            //    get
            //    {
            //        return Arr[i];
            //    }
            //    set
            //    {
            //        if (value < 0)
                    
            //            throw new ArgumentException("Deyer menfi ola bilmez");
                    
            //        if (i > Arr.Length)
                    
            //            throw new ArgumentException("Indeks massivin uzunlugundan boyuk ola bilmez.");
            //        Arr[i] = value;
            //    }
            //}
            public Test()
            {
                //Arr = new int[10];
            }
        }
    }
}
