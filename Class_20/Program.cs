using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_20
{
    class Program

    {
        delegate double Mydelegate(double R);
        static void Main(string[] args)
        {
            Mydelegate mydelegate = LengthCircle;
            double length = mydelegate(10); // вызвали метод LengthCircle
            Console.WriteLine("{0:0.000}", length);

            mydelegate = SquareCircle;
            double square = mydelegate(10); // вызвали метод SquareCircle
            Console.WriteLine("{0:0.000}", square);

            mydelegate = VolumeBall;
            double volume = mydelegate(10); // вызвали метод VolumeBall
            Console.WriteLine("{0:0.000}", volume);

            Console.ReadKey();
        }

        //метод получает радиус R и вычисляет длину окружности 
        static double LengthCircle(double R) => (double)Math.PI * 2 * R;


        //метод получает радиус R и вычислят площадь круга
        static double SquareCircle(double R) => (double)Math.PI * R * R;



        //метод получает радиус R и вычислят объем шара
        static double VolumeBall(double R) => (double)4 / 3 * Math.PI * R * R * R;
    }
}
