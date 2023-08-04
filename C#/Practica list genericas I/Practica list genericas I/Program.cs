using System.Collections.Generic;


namespace Practica_List_generica_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Una lista es una especie de arreglo en el cual 
            podemos agregar o eliminar elementos con el programa 
            en ejecucion */

            // 1. Crear lista y agregar valores //

            List<int> Valores = new List<int>(); // creando la lista genericallamada valores de tipo int 
            int n = 0;
            int r = 0;


            /* Para agregar algun dato a la lista debemos de poner
             * el nombre seguido del metodo add y entre () el parametro 
             * que queremos guardar */

            Valores.Add(7);
            Valores.Add(5);
            Valores.Add(4);
            Valores.Add(3);
            Valores.Add(8);
            Valores.Add(9);

            // recorremos la lista con un for 
            for (n = 0; n < Valores.Count; n++)
            {
                r = Valores[n];
                Console.WriteLine(r);  // immprimir los datos en consola 

            }
            Console.WriteLine("- - - - -");

            // 2. Comprobar si un elemento existe 

            /* Para detectar si existe un elemento dentro de la lista se 
             * utiliza el metodo ".contains" seguido del tipo de dato con
             * el que va a trabajar "<int>" luego el elemento que deseas 
             * saber si existe (5) si el elemento existe va a salir un dato
             * "True" y de no existir seria un dato "False"  */

            Console.WriteLine(Valores.Contains<int>(5));
            Console.WriteLine(Valores.Contains<int>(17));
            Console.WriteLine("- - - - -");



            // 3. Obtener el indice de un elemento 

            /* Vamos a tomar un valor y si esta en la lista este imprimira el 
             * indice , de no existir el indexof imprimira un -1 */

            Console.WriteLine(Valores.IndexOf(4));
            Console.WriteLine("- - - - -");



            // 4. Insertar un elemento en un indice 

            /* para insertar un elemento en un indice debemos de utilizar el metodo
             * ".Insert" colocando los dos parametros en parentesis (primero el indice , luego el valor ) */

            Valores.Insert(2, 55);


            foreach (int valor in Valores) 
            {
                Console.WriteLine(valor);
               
            }
            Console.WriteLine("- - - - -");


            // 5. Eliminar un elemento de un indice 

            /* para eliminar un elemento de un indice utilizamos el metodo RemoveAt seguido
             * del indice a elmininar () */

            Valores.RemoveAt(3);

            foreach (int valor in Valores)
            {
                Console.WriteLine(valor);

            }
            Console.WriteLine("- - - - -");


            // 6. Eliminar un elemento en especifico 

            /* para eso necesitamos colocar el elemento en especifico que queremos eliminar
             * en caso de haber varios valores iguales este va a eliminar eo primero que aparezca */

            Valores.Remove(8);

            foreach (int valor in Valores)
            {
                Console.WriteLine(valor);

            }
            Console.WriteLine("- - - - -");

            







        }
    }
}




