using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_перегрузка_операторов_2
{
    class Complex
    {
        //поля через авто-свойства
        private double Re { get; set; } //действительная часть
        private double Im { get; set; } //мнимая часть

        public Complex () { Re = Im = 0; }

        public Complex( double re, double im) { Re = re; Im = im; }

        public double Norm()
        {
            return Math.Sqrt(Re * Re + Im * Im);
        }

        //умножение перегрузка оператора * для работы  с классом

        public static Complex operator*(Complex a, Complex b)
        {
            double Res_Re = a.Re * b.Re - a.Im * b.Im;
            double Res_Im = a.Re * b.Im + a.Im * b.Re;
            return new Complex(Res_Re, Res_Im);

        }

        //перегрузка с умножением на действительное число
        public static Complex operator* (Complex a, double b)
        {
            return new Complex(a.Re * b, a.Im * b);
        }

        public static Complex operator *(double a, Complex b)
        {
            //return new Complex(a * b.Re, a * b.Im);
            return b * a;
        }

        //перегрузка унарного минус

        public static Complex operator- (Complex a)
        {
            return new Complex(-a.Re, -a.Im);
        }

        //инкреммент.декремент
        public static Complex operator++(Complex a)
        {
            return new Complex(++a.Re, ++a.Im);
        }

        public static Complex operator --(Complex a)
        {
            return new Complex(--a.Re, --a.Im);
        }

        //оператор отношений < <= > => == !=

        public static bool operator<(Complex a , Complex b)
        {
            return a.Norm() < b.Norm();
        }

        public static bool operator >(Complex a, Complex b)
        {
            return a.Norm() > b.Norm();
        }

        //операторы == !=

        public override bool Equals (object obj)
        {   if (obj is Complex)
            {
                Complex a = (Complex)obj;
                return Re == a.Re && Im == a.Im;
            }
            return false;
            
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public static bool operator ==(Complex a, Complex b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(Complex a, Complex b)
        {
            return !a.Equals(b);
        }

        //оператор false true

        public static bool operator true (Complex a)
        {
            if (a.Re != 0 || a.Im != 0)
                return true;
            else return false;
        }

        public static bool operator false(Complex a)
        {
            return a.Re == 0 && a.Im == 0 ? true : false;
        }

        // моделирование логических операторов с помощью перегрузки  
        // операторов & и |

        public static Complex operator&(Complex a, Complex b)
        {
        if (a.Re != 0 && a.Im !=0 && b.Re!= 0 && b.Im !=0)
                return a;

            return new Complex();
        }

        public static Complex operator|(Complex a, Complex b)
        {
        if(a.Re != 0 || a.Im !=0 )
                return a;

         if(b.Re != 0 || b.Im !=0 )
                return b;

            return new Complex();
        }

        //методы приведения типов
        //неявное double ->Complex
        public static implicit operator Complex (double number)
        {
         return new Complex (number, 0);
        }

         //явное Complex  -> double
          public static explicit operator double (Complex number)
          {
            return number.Re;
          }
        public override string ToString()
        {
            return $" ({Re} + {Im}i)"; 
        }
    }
}
