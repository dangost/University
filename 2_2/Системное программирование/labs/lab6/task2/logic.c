#include "logic.h"
#include <unistd.h>
#include <stdio.h>

int randomizeDigits(int min, int max)
{
return rand() % max + min;
}

int printArray(int* array, int size)
{
for(int i = 0; i < size; i++)
{
printf("%d ", array[i]);
}
printf("\n");
}

void sortMassive(int* massive, int amount)
{
for (int i = 0; i < amount - 1; i++)
{

for (int j = 0; j < amount - i - 1; j++)
{
if (massive[j] > massive[j + 1])
{
int temp = massive[j];
massive[j] = massive[j + 1];
massive[j + 1] = temp;
}
}
}
} 
