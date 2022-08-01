using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero;

            float a;

            float b;

            float c;

            float h;

            float LaOtraH;

            double pi = 3.1416;

            float r;

            Console.WriteLine("\n-----------------ejercicio 1 -------------------------------------------\n");

            Console.Write("ingrese un numero: \n");
            entero = int.Parse(Console.ReadLine());

            //Console.Write("ingrese otro numero: \n");
            //  entero2 = int.Parse(Console.ReadLine());

            Console.Write("el resultado en minutos es de: " + (entero * 60) + " y el resultado en segundos es de: " + (entero * 60 * 60));


            Console.WriteLine("\n-----------------ejercicio 2 -------------------------------------------\n");


            Console.Write("ingrese el primer lado: \n");
            a = float.Parse(Console.ReadLine());

            Console.Write("ingrese el segundo lado: \n");
            b = float.Parse(Console.ReadLine());

            Console.Write("ingrese la base: \n");
            c = float.Parse(Console.ReadLine());

            Console.Write("ingrese la altura: \n");
            h = float.Parse(Console.ReadLine());

            float Area = (b * h) / 2;

            float perimetro = a + b + c;

            Console.Write("el area segun los datos que ingreso es de: " + Area + " y el resultado del perimetro es de: " + perimetro);


            Console.WriteLine("\n-----------------ejercicio 3-------------------------------------------");


            Console.Write("ingrese el radio: \n");
            r = float.Parse(Console.ReadLine());

            Console.Write("ingrese la altura: \n");
            LaOtraH = float.Parse(Console.ReadLine());

            double AreaCilindro = (2 * pi) * r * (LaOtraH + r);

            double volumen = pi * (r * r) * LaOtraH;

            Console.Write("el area del cilindro es de: " + AreaCilindro + " y el volumen es de: " + volumen);

            Console.WriteLine("\n-----------------ejercicio 4-------------------------------------------\n");


            Console.Write("ingrese el primer valor: \n");
            float Primero = float.Parse(Console.ReadLine());

            Console.Write("ingrese la altura: \n");
            float segundo = float.Parse(Console.ReadLine());

            float suma = Primero + segundo;
            float resta = Primero - segundo;
            float division = Primero / segundo;
            float multi = Primero * segundo;

            Console.Write("la suma es de: " + suma + ", la resta es de: " + resta + ", la division es de: " + division + ", la multiplicacion es de: " + multi);

            Console.WriteLine("\n-----------------ejercicio 5-------------------------------------------\n");

            Console.Write("ingrese su nombre: \n");
            string nombre = Console.ReadLine();

            Console.Write("ingrese su edad: \n");
            int edad = int.Parse(Console.ReadLine());

            Console.Write("ingrese el peso: \n");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("ingrese la estatura: \n");
            float estatura = float.Parse(Console.ReadLine());

            Console.Write("tipo de sangre: \n");
            string TipoDeSangre = Console.ReadLine();

            Console.Write("--resumen de los datos--\n");
            Console.Write("nombre: " + nombre + " edad: " + edad + " peso: " + peso + " estatura: " + estatura + " tipo de sangre: " + TipoDeSangre);
            Console.Read();
        }
    }
}
