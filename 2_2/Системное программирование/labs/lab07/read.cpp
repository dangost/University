#include <iostream>
#include <pthread.h>
#include "read.h"
#include "struct.h"


using namespace std;

void* fillArray(void* arg)
{

	thread_arg targ = *(thread_arg*) arg; 

	cout << "Reading array: \n"; 
	for (int i = 0; i < targ.length; i++) 
	{
		cin >> targ.array[i];
    }
    cout << endl;
    return NULL;
}