#include <iostream>
#include <pthread.h>
#include "logic.h"
#include "struct.h"

using namespace std;

void* summary(void* arg)
{
	thread_arg *targ = (thread_arg*) arg; 
	double sum = 0;
	for (int i = 0; i < targ->length; i++) 
	{
		sum += targ->array[i];
    }

    targ->summary = sum;
   	pthread_exit (NULL);
}