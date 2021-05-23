#include "logic.h"

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