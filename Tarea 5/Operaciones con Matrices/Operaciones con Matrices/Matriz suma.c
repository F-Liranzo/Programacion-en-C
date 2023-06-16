#include <stdio.h>
#define FILAS 3 // se definen las constantes para el tamaño de la matriz //
#define COLUMNAS 3

void sumarMatrices(int matriz1[FILAS][COLUMNAS], int matriz2[FILAS][COLUMNAS], int matrizSuma[FILAS][COLUMNAS]);

int main() {
    int matriz1[FILAS][COLUMNAS];// se declaran todas las funciones con un tamaño filas x columnas//
    int matriz2[FILAS][COLUMNAS];
    int matrizSuma[FILAS][COLUMNAS];

    // el usuario que ingresa los elementos de la primera matriz
    printf("Ingrese los elementos de la matriz 1:\n");
    for (int i = 0; i < FILAS; i++) {
        for (int j = 0; j < COLUMNAS; j++) {
            scanf("%d", &matriz1[i][j]);
        }
    }

   // el usuario que ingresa los elementos de la segunda matriz
    printf("Ingrese los elementos de la matriz 2:\n");
    for (int i = 0; i < FILAS; i++) {
        for (int j = 0; j < COLUMNAS; j++) {
            scanf("%d", &matriz2[i][j]);
        }
    }

    // Llamar a la función para sumar las matrices
    sumarMatrices(matriz1, matriz2, matrizSuma);

    // Imprimir la matriz resultante
    printf("La matriz resultante de la suma es:\n");
    for (int i = 0; i < FILAS; i++) {
        for (int j = 0; j < COLUMNAS; j++) {
            printf("%d ", matrizSuma[i][j]);
        }
        printf("\n");
    }

    return 0;
}

// Función para sumar las matrices
void sumarMatrices(int matriz1[FILAS][COLUMNAS], int matriz2[FILAS][COLUMNAS], int matrizSuma[FILAS][COLUMNAS]) {
    for (int i = 0; i < FILAS; i++) {
        for (int j = 0; j < COLUMNAS; j++) {
            // Sumar los elementos correspondientes de las dos matrices y almacenar el resultado en la matriz suma
            matrizSuma[i][j] = matriz1[i][j] + matriz2[i][j];
        }
    }
}
