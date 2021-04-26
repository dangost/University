#include <iostream>

using namespace std;

 /*
    В одномерном массиве, состоящем из n целых элементов, вычислить: произ-
    ведение элементов массива с четными номерами и сумму элементов массива,
    расположенных между первым и последним нулевыми элементами.
 */

int powOfEven(int a[], int);

int sumBetweenZeros(int a[], int);

void printArray(int a[], int);


int main()
{
    cout << "Input length" << endl;

    int len; cin >> len;

    int * array = new int(len);

    cout << "Starting entering values:\n";

    for(int i = 0; i < len; i++)
    {
        cin >> array[i];
    }

    // array is full
    printArray(array, len);

    int pow = powOfEven(array, len);
    int sum = sumBetweenZeros(array, len);

    cout << "Pow: " << pow << "\t" << "Sum: " << sum << endl;

}

int powOfEven(int array[], int len)
{
    int pow = 1;

    for(int i = 0; i< len; i++)
    {
        if(i % 2 == 0)
        {
            pow *= array[i];
        }
    }

    return pow;
}

int sumBetweenZeros(int array[], int len)
{
    int zero = 0;

    int sum = 0;
    for(int i = 0; i < len; i++)
    {
        if(array[i] == 0)
        {
            zero++;
        }

        if(zero == 1)
        {
            sum += array[i];
        }

        else if(zero > 1)
            break;
    }

    return sum;
}

void printArray(int array[], int len)
{
    for(int i = 0; i < len; i++)
    {
        cout << array[i] << " ";
    }

    cout << "\n";
}