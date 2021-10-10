#include <signal.h>
#include <stdio.h>
#include <unistd.h>
#include <iostream>

using namespace std;

double progress(double sum);

void user(int sig);
void bank(int sig);

double score;

int main()
{
    score = 50.0;

    (void) signal (SIGUSR1, user);
    raise(SIGUSR1);

    while(1)
        sleep(1);
}

void user(int sig)
{
    cout << "User send request! " << score << "\n" << endl;
    sleep(1);

    (void) signal(SIGUSR2, bank);
    raise(SIGUSR2);
}

void bank(int sig)
{
    score = progress(score);
    cout << "Bank return response! " << score << "\n" << endl;
    sleep(1);

    if (score > 100)
    {
        exit(0);
    }

    (void) signal(SIGUSR1, user);
    raise(SIGUSR1);
}

double progress(double sum)
{
    return sum + 0.1 * sum;
}