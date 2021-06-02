#include <math.h>
#include <iostream>
#include <pthread.h>
#include "read.h"
#include "output.h"
#include "logic.h"
#include "struct.h"

using namespace std;


int main()
{
    pthread_t readThread, calcThread, printConsoleThread, printFileThread;

	cout << "Enter the size of the array:";
	int size;
	cin >> size;
	double *arr = new double[size];

	thread_arg targ;
	targ.array = arr;
	targ.length = size;
    
    pthread_create(&readThread, NULL, &fillArray, &targ);
    pthread_join(readThread, NULL);
    pthread_create(&printConsoleThread, NULL, printArray, &targ);
    pthread_create(&printFileThread, NULL, printArrayFile, &targ);
    
    pthread_create(&calcThread, NULL, summary, &targ);
    pthread_join(calcThread, NULL);
	cout << "Sum of elements = " << targ.summary << endl;
}