#include <stdio.h>
#include <stdlib.h>
#include<math.h>
#define MAX_CLIENTES 50
#define GASTOS "Gastos.txt"


struct gasolina // estructura de datos //
{
    char cliente[30]; // nombre de clientes //
     float distancia;  // distancia de clientes //
    float cmax; // consumo maximo //
    float cmin; // consimo minimo //
    float pres; // presicion del consumo //
};

int main()
{
    system("cls"); 
    printf("Este es un programa utilizado para calcular el precio de los kilometros recorridos de un vehiculo  \n");
   
    // Precio combustible x galon //
    float gas;
    printf(" Especifique el precio de la gasolina \n RD$: ");
    scanf("%f", &gas);

     // Precio x Gomas //
     float precioNeumaticos;
    int vidaUtil = 50000;
    printf("Ingrese el precio de los neumaticos: \n RD$:");
    scanf("%f", &precioNeumaticos);
    float costoPorKm = precioNeumaticos / vidaUtil; 
    //printf("El costo por kilometro de los neumaticos es: %.2f\n", costoPorKm*4);

    // Cantidad de clientes a calcular //
    int n;
    printf(" Cuantos clientes desea calcular ? \n");
    scanf("%d", &n);
   

   // presicion //
   float p; 
   printf("Ingresa la presicion del calculo");
    scanf("%f", &p);
    system("cls"); 

    // Aceite 
    float cambio_de_aceite_km = 20000;
    float precio_aceite = 2000;
    float preciox_km = precio_aceite / cambio_de_aceite_km ;

    // seguro 
    int km_anuales = 20000;
    int costo_seguro = 4000;
    float seguro = costo_seguro / km_anuales; 


    struct gasolina gasola[MAX_CLIENTES]; // declarando arreglo de estructuras //

    // Entrada de datos //
    for (int i = 0 ; i < n; i++) 
    {

        printf("\nCliente # %d:\n", i + 1);
        printf("-------------------------------------------\n");
        printf("Ingresa el nombre del cliente: \n");
        scanf("%s", &gasola[i].cliente);
        printf("Ingresa la distancia del cliente: \n");
        scanf("%f", &gasola[i].distancia);
        printf("Ingresa la eficiencia Minima del cliente:\n (litros/100km) ");
        scanf("%f", &gasola[i].cmin);
        printf("Ingresa la eficiencia Maxima del cliente: \n (litros/100km)");
        scanf("%f", &gasola[i].cmax);
        system("cls");
        //printf("Ingresa con que presicion desea calcular los datos :  ");
        //scanf("%f", &gasola[i].pres);
        printf("---------------------------------------------------------------------------\n");
    }
    printf("\n\n\n");
    
    
    
    // Abre el archivo en modo de escritura

     FILE *archivo;
    archivo = fopen(GASTOS , "w");
    if (archivo == NULL) 
    {
        printf("No se pudo abrir el archivo.\n");
        return 1;
    }


    
    for (int i = 0; i < n; i++)
    {
        
        system("cls");
        printf("\n                 Tabla de calificaciones:\n"); 
        for (int i = 0; i < n; i++) 
        {
            printf("Usuario #%d \n", i);
            printf("----------------------------| %-15s |----------------------------\n", gasola[i].cliente);
            printf("---------------------------------------------------------------------------\n");
            printf("| %-11s | %-11s | %-11s | %-11s | %-11s  |\n", "distancia","presicion","Gasto gas", "gastos varios", "total");

            fprintf(archivo,"Usuario #%d \n", i);
            fprintf(archivo,"----------------------------| %-15s |----------------------------\n", gasola[i].cliente);
            fprintf(archivo,"---------------------------------------------------------------------------\n");
            fprintf(archivo,"| %-11s | %-11s | %-11s | %-11s | %-11s  |\n", "distancia","presicion","Gasto gas", "gastos varios", "total");



            // calculo gasolina // 
            for (float c = gasola[i].cmin; c <= gasola[i].cmax; c +=p) 
            {
            // calculo presicion conbustible //
            float consumo = c / 100;
            float consumolt = consumo * gasola[i].distancia;
            float precio_total_gas = consumolt * (gas / 3.78541);
            
            
            // costo de las gomas //
            float precioxgoma = costoPorKm * gasola[i].distancia;
            float totalgoma = precioxgoma * 4;

            float gastosv = totalgoma + preciox_km + seguro;
            float total = precio_total_gas + gastosv;

            
             printf("| %-11.2f |  %-10.2f |  %-10.2f |  %-10.2f   |  %-10.2f  |\n", gasola[i].distancia , c, precio_total_gas ,gastosv,total );
            printf("---------------------------------------------------------------------------\n");
            
            fprintf(archivo,"| %-11.2f |  %-10.2f |  %-10.2f |  %-10.2f   |  %-10.2f  |\n", gasola[i].distancia , c, precio_total_gas ,gastosv,total );
            fprintf(archivo,"---------------------------------------------------------------------------\n");
            }
        } 

       
    }
fclose(archivo);
return 0; 
    
    }

