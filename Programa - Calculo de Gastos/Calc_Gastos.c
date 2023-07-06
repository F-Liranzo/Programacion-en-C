#include <stdio.h>
#include <stdlib.h>

#define MAX_CLIENTES 50

float gas = 23.04;  /* este es el precio de la gasolina por km , para encontrar
 este dato lo que hice fue encontrar la media del consumo del vehiculo,
  que fueron un minimo de 8 litros y un maximo de 16 --- esto nos
   da 12 litros a los 100 que es igual a 0.12.//

//suponiendo que la gasolina cuesta 192.00 , multiplicamos 192 x 0.12 = 23.04
*/




float varios = 200;// aqui le pongo el valor 200 como un aprozimado a los gastos varios //

struct gasolina // estructura de datos //
{
    char cliente[30]; // nombre de clientes
    float distancia;// distancia de cliente

};

int main ()
{
    int n;
    system ("cls");
    printf (" Cuantos clientes desea calcular \n\n");
    scanf("%d",&n);

    struct gasolina gasola [MAX_CLIENTES]; //declarando arreglo de estructuras //


      for (int i = 0; i < n; i++) // utilizo un bucle for para dar entrada a los datos
      {
        printf("\nIngrese los datos del del cliente  %d:\n", i+1);
        printf("Nombre del cliente ");
        scanf("%s", &gasola[i].cliente);
        printf("distacia: ");
        scanf("%f", &gasola[i].distancia );

      }
      printf("\n\n\n");
      system ("cls");

       for (int i = 0; i < n; i++)
       {
           float gasto = gasola[i].distancia * gas; //variable para calcular el gasto de combustible //
           float total = gasto + varios; // este suma los datos para encontrar el total //

           

           system ("cls");
           printf("\nTabla de calificaciones:\n"); // para crear la tabla utilice %-15 para especificar el ancho de cada una de las barrar , limitando los caracteres//
    printf("-------------------------------------------------------------------------\n");
    printf("| %-15s | %-10s | %-11s | %-11s | %-11s |\n", "cliente", "distancia", "Gasto gas" ,"Varios","total");
    printf("-------------------------------------------------------------------------\n");

    for (int i = 0; i < n; i++)    //bucle para imprimir la tabla //
    {

        printf("| %-15s | %-10.2f |  %-10.2f |  %-10.2f |  %-10.2f |\n",  gasola[i].cliente, gasola[i].distancia, gasto,varios,total);
    }
    return 0;



}
}
