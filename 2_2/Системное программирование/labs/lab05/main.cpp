#include <iostream>
#include "logic.h"

using namespace std;

 /*
    Ввести массив вещественных чисел размером N. Найти его наибольший и
    наименьший элементы и поменять их местами. Найти сумму и произведение
    всех элементов массива.
 */

void printArray(double array[], int len)
{
    for(int i = 0; i < len; i++)
    {
        cout << array[i] << " ";
    }

    cout << "\n";
}


int main()
{
    cout << "Input length: ";
    int len; cin >> len;

    double * array = new double(len);

    cout << "Starting entering values:\n";

    int value;
    for(int i = 0; i < len; i++)
    {
        cin >> value;
        array[i] = value;
    }

    // array is full
    printArray(array, len);

    int maxId = findMaxIndex(array, len);
    int minId = findMinIndex(array, len);

    cout << "Max: " << array[maxId] << "\t" << "Min: " << array[minId] << endl;

    // swap
    double temp = array[maxId];
    array[maxId] = array[minId];
    array[minId] = temp;

    cout << "Swaping.." << endl;
    printArray(array, len);

    double sum = findSumOfFull(array, len);

    double pow = findPowOfFull(array, len);

    cout << "Sum: " << sum << "\t" << "Pow: " << pow << endl;
}