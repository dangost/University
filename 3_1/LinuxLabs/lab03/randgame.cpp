#include <stdio.h>
#include <unistd.h>
#include <signal.h>
#include <time.h>
#include <stdlib.h>
#include <iostream>

using namespace std;


time_t curtime;
struct tm * loctime;

int score;


void sigalrmHandler_1(int sig)
{
    srand(time(NULL)); // seed

    cout << "First Player" << endl;

    score += rand() % 100;

    cout << score << endl;
}


void sigalrmHandler_2(int sig)
{
    cout << "Second Player" << endl;

    srand(time(NULL)); // seed

    score -= rand() % 100;

    cout << score << endl;
}


int main()
{
    score = 0;

    for(int i = 0; i < 10; i++)
    {
        i % 2 == 0 
        ? signal(SIGALRM, sigalrmHandler_2) 
            : signal(SIGALRM, sigalrmHandler_1);
        
        raise(SIGALRM);
        sleep(1);
    }

    if (score > 0)
    {
        cout << "First player Win!" << endl;
    }

    else if (score < 0)
    {
        cout << "Second player Win!"<< endl;
    }

    else
    {
        cout << "Draw"<< endl;
    }
}