using Practica4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolapractica4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escriba el desayuno que desea ordenar:");

            String desayunos = Convert.ToString(Console.ReadLine()); //La línea de código que proporciona convierte la entrada del usuario que se lee con Console.ReadLine() a una cadena de texto (string) y la almacena en la variable desayuno, lo mismo ocurre para los casos siguientes.

            Console.WriteLine("Escriba la pasta,antojo o ensalada que desea ordenar:");
            String pastas_antojos_ensaladas = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Escriba el pollo o hamburguesa que desea ordenar:");
            String pollo_hamburguesa = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Escriba la carne que desea ordenar:");
            String carnes = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Escriba el platillo del mar que desea ordenar:");
            String del_mar = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Escriba el caldo o snack que desea ordenar:");
            String caldos_snack = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Escriba el postre que desea ordenar:");
            String postres = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Escriba la bebida que desea ordenar:");
            String bebidas = Convert.ToString(Console.ReadLine());

            //Se declaran las variables de tipo string, para dar entrada a los datos solicitados. 

            String d = Ordenar.Orden1(desayunos);
            String p = Ordenar.Orden2(pastas_antojos_ensaladas);
            String ph = Ordenar.Orden3(pollo_hamburguesa);
            String c = Ordenar.Orden4(carnes);
            String dm = Ordenar.Orden5(del_mar);
            String cs= Ordenar.Orden6(caldos_snack);
            String po = Ordenar.Orden7(postres);
            String be = Ordenar.Orden8(bebidas);

            // Console.WriteLine es una función que se utiliza para imprimir una línea de texto en la consola. En este caso concatenamos las variables declaradas anteriormente. 
            Console.WriteLine("El desayuno que ordenó es: " + d);
            Console.WriteLine("La pasta_antojo o ensalada que ordenó es: " + p);
            Console.WriteLine("El pollo o hamburguesa que ordenó es: " + ph);
            Console.WriteLine("La carne que ordenó es: " + c);
            Console.WriteLine("Del mar que ordenó es: " + dm);
            Console.WriteLine("El caldo o snack que ordenó es: " + cs);
            Console.WriteLine("El postre que ordenó es: " + po);
            Console.WriteLine("La bebida que ordenó es: " + be);

            Console.ReadLine();//es una función que se utiliza para leer una entrada de usuario desde la consola. Cuando esta línea de código se ejecuta, el programa espera a que el usuario ingrese una línea de texto y presione la tecla Enter.
        }
    }
}
