using System;
/*4) Guardar en un arreglo la cantidad de días que tiene cada mes del año (año no bisiesto) y
luego pedir al usuario que ingrese un mes (1=enero 12=diciembre) y según dicho valor mostrar
por pantalla los días de dicho mes.*/
namespace TP8C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int valorUsuario = 0;
            int [] arrayMes = {31,28,31,30,31,30,31,31,30,31,30,31};
            String [] arrayNombre = {"Enero","Febrero","Marzo","Abril","Mayo","Junio","Julio","Agosto","Septiembre","Octubre","Noviembre","Diciembre"};
            Console.WriteLine("Ingrese un numero entero para identificar el mes");
            Console.WriteLine("(Ejemplo: 1 - Enero))");
            valorUsuario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Has elegido "+ arrayNombre[valorUsuario -1] + ", el cual tiene "+arrayMes[valorUsuario - 1]+" días.");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }
    }
}
