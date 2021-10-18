#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <errno.h>
#include <unistd.h>
#include <sys/msg.h>
#include <iostream>
#include <thread>

using namespace std;

struct message
{
    long int message_type;
    char payload[BUFSIZ];
};

void running()
{
    int running = 1;
    int msgid;
    struct message data;

    long int message_to_recieve = 0;

    msgid = msgget((key_t) 1234, 0666 | IPC_CREAT);
    if (msgid == -1)
    {
        cout << "msget failed";
        exit(EXIT_FAILURE);
    }

    while (running)
    {
        if (msgrcv(msgid, (void*) & data, BUFSIZ, message_to_recieve,0) == -1)
        {
            cout << "msgrcv failed!";
            exit(EXIT_FAILURE);
        }

        cout << "Client " << "Text captured: " << data.payload << endl;

        if (strncmp(data.payload, "end", 3) == 0)
        {
            running = 0;
        }

        if (msgctl(msgid, IPC_RMID, 0) == -1)
        {
            cout << "msgctl failed!" << endl;
            exit(EXIT_FAILURE);
        }

        cout << "client terminated!" << endl;

        exit(EXIT_SUCCESS);
    }
}

int main()
{
    thread client_2(running);
    client_2.join();

    return 0;
}