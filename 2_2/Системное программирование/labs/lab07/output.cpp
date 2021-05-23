#include <iostream>
#include <pthread.h>
#include "output.h"
#include "struct.h"

using namespace std;

void* printArray(void* arg)
{
	thread_arg targ = *(thread_arg*) arg; 
	for (int i = 0; i < targ.length; i++) 
	{
		cout << targ.array[i] << " ";
    }
    cout << endl;
    return NULL;
}



void* printArrayFile(void* arg)
{
	thread_arg targ = *(thread_arg*) arg;
    FILE* f = fopen("array.txt", "w");
    for( int i=0; i<targ.length; i++)
    {
    	fprintf(f, " %f", targ.array[i]);
    } 
    fclose(f);
    return NULL;
}