#include<stdio.h>
#include<math.h>

/* Par, impar o nulo.
NUM: variable de tipo entero. */

void main(void)
{
    int NUM;
    printf("ingrese el numero: ");
    scanf("%d ",&NUM);
    if(NUM == 0)
        Printf("\nNulo");
    else
        if(POW(-1 , NUM)> 0)
        printf("\nPar");
    else
        printf("\nimpar");
}
