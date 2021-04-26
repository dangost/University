#include <iostream>

using namespace std;

 /*
    Ввести массив вещественных чисел размером N. Найти его наибольший и
    наименьший элементы и поменять их местами. Найти сумму и произведение
    всех элементов массива.
 */

int findMaxIndex(double a[], int);

int findMinIndex(double a[], int);

double findSumOfFull(double a[], int);

double findPowOfFull(double a[], int);

void printArray(double a[], int);


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

int findMaxIndex(double array[], int len)
{
    int maxId = 0;
    double max = array[maxId];

    for(int i = 1; i < len; i++)
    {
        if(max < array[i])
        {
            max = array[i];
            maxId = i;
        }
    }

    return maxId;
}

int findMinIndex(double array[], int len)
{
    int minId = 0;
    double min = array[minId];

    for(int i = 1; i < len; i++)
    {
        if(min > array[i])
        {
            min = array[i];
            minId = i;
        }
    }

    return minId;

}

double findSumOfFull(double array[], int len)
{
    double sum = 0;
    for(int i = 0; i < len; i++)
    {
        sum += array[0];
    }

    return sum;
}

double findPowOfFull(double array[], int len)
{
    double pow = 1;
    
    for(int i = 0; i < len; i++)
    {
        pow *= array[i];
    }

    return pow;
}

void printArray(double array[], int len)
{
    for(int i = 0; i < len; i++)
    {
        cout << array[i] << " ";
    }

    cout << "\n";
}