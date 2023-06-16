#include <stdio.h>
#define FILAS 3  // se definen las constantes para el tamaño de la matriz //
#define COLUMNAS 3

void restarMatrices(int matriz1[FILAS][COLUMNAS], int matriz2[FILAS][COLUMNAS], int matrizResta[FILAS][COLUMNAS]);

int main() {
    int matriz1[FILAS][COLUMNAS];  // se declaran todas las funciones con un tamaño filas x columnas//
    int matriz2[FILAS][COLUMNAS];
    int matrizResta[FILAS][COLUMNAS];

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
 // Llamar a la función para restar  las matrices
    restarMatrices(matriz1, matriz2, matrizResta);

     // Imprimir la matriz resultante
    printf("La matriz resultante de la resta es:\n");
    for (int i = 0; i < FILAS; i++) {
        for (int j = 0; j < COLUMNAS; j++) {
            printf("%d ", matrizResta[i][j]);
        }
        printf("\n");
    }

    return 0;
}

// Función para restar las matrices
void restarMatrices(int matriz1[FILAS][COLUMNAS], int matriz2[FILAS][COLUMNAS], int matrizResta[FILAS][COLUMNAS]) {
    for (int i = 0; i < FILAS; i++) {
        for (int j = 0; j < COLUMNAS; j++) {
            matrizResta[i][j] = matriz1[i][j] - matriz2[i][j];
        }
    }
}

