using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MathHelper MH1 = MathHelper.Instance;

            Console.WriteLine(MH1.AddNumbers(5, 4));

            Console.WriteLine(MH1.IsNegative(-9));
        }
    }

    //Create the MathHelper class
    public sealed class MathHelper 
    {
        //Private constructor, prevents instantiations
        MathHelper() { }

        //Private object that is the one instance of the class
        static readonly MathHelper MH = new MathHelper();

        //Returns the one instance of the class
        public static MathHelper Instance
        {
            get { return MH; }
        }

        public int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool IsNegative(int num)
        {
            return num < 0;
        }
    }

}
