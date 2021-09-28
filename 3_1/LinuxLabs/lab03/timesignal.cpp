#include <stdio.h>
#include <unistd.h>
#include <signal.h>
#include <time.h>
#include <stdlib.h>
#include <iostream>

using namespace std;


time_t curtime;
struct tm * loctime;


void sigalrmHandler_1(int sig)
{
    cout << "First Handler" << endl;
    curtime = time(0);
    loctime = localtime(&curtime);
    fputs(asctime(loctime), stdout);
    cout << "\n";
}


void sigalrmHandler_2(int sig)
{
    cout << "Second Handler" << endl;
    curtime = time(0);
    loctime = localtime(&curtime);
    fputs(asctime(loctime), stdout);
    cout << "\n";
}


int main()
{
    int i = 0;

    while (i++ < 10)
    {
        if (i % 2 == 0)
        {
            signal(SIGALRM, sigalrmHandler_2);
        }

        else 
        {
            signal(SIGALRM, sigalrmHandler_1);
        }
        
        raise(SIGALRM);
        sleep(1);
    }
}