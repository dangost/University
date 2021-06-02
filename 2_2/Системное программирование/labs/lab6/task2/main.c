#include "fileUtils.h"
#include "logic.h"
#include <stdio.h>
#include <string.h>
#include <unistd.h>

int main()
{

const int SIZE = 10;
const char* FILENAME = "digits.txt";

createFile(FILENAME);
int digits[SIZE];
int temp[SIZE];

for (int i = 0; i < SIZE; i++)
{
digits[i] = randomizeDigits(0, 20);
}

printArray(digits, SIZE);

fileAppend(FILENAME, digits, SIZE);
printf("Файл записан\n");

fileRead(FILENAME, temp, SIZE);
printf("Файл прочитан\n");

sortMassive(temp, SIZE);
fileAppend(FILENAME, temp, SIZE);
printArray(temp, SIZE);
} 
