using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_перегрузка_операторов_2
{
    class Program
    {

        static void Task_1()
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(3, 4);
            Complex c = 10 * b;
            Console.WriteLine($"10 * {b} = {c}");
        }
        static void Task_2()
        {
            Complex a = new Complex(1, 2);
            double b = 10;
            Complex c = a * b;
            Console.WriteLine($"{a} * {b} = {c}");
        }
        static void Task_3()
        {
            Complex a = new Complex(1, 2);
            Console.WriteLine($"-{a} = {-a}");
        }

        
        static void Task_4()
        {
            Complex a = new Complex(1, 2);
            Complex b = a--;
            Console.WriteLine($" a = {a}, b = {b}");
        }

        static void Task_5()
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(2, 3);
            if (a > b) { Console.WriteLine("a>b"); }
            else Console.WriteLine("a<=b");
        }
        static void Task_6()
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(2, 3);
          
            if (a.Equals(b)) { Console.WriteLine("a==b"); }
            else Console.WriteLine("a!=b");
        }
        static void Task_7()
        {
            Complex a = new Complex(1, 2);
            Complex b = new Complex(1, 2);

            if (a==b) { Console.WriteLine("a==b"); }
            else Console.WriteLine("a!=b");
        }

        static void Task_8()
        {
            Complex a = new Complex(1, 0);
            Complex b = new Complex(1, 2);

            if (a) { Console.WriteLine("Non zero"); } // a!= 0+0i 
            else Console.WriteLine("Zero"); // a==0+0i
        }

        static void Task_9()
        {
        Complex a1= new Complex(0,0);
        Complex a2= new Complex(1,1);
            if (a1&a2)
            {
            Console.WriteLine("First");//не увидим
            }
            if (a1||a2)
                Console.WriteLine("Second");//увидим
        }

        static void Task_10()
        {
            Complex a;
            double b = 10; 
            a= b;         //неявное приведение
            Console.WriteLine(a);
        }
        static void Task_11()
        {
            Complex a = new Complex(10,10);
            double b = (double) a; 
            
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            Task_11();
        }
    }
}
