#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <errno.h>
#include <unistd.h>
#include <sys/msg.h>
#include <iostream>
#include <thread>

#define MAX_TEXT 512

using namespace std;

struct message
{
    long int message_type;
    char payload[BUFSIZ];
};

void sending(int msgid)
{
    int running = 1;

    while(running) 
    {
        struct message data;
        long int message_to_recieve = 0;
        char buffer[BUFSIZ];

        fgets(buffer, BUFSIZ, stdin);

        data.message_type = 1;

        strcpy(data.payload, buffer);

        if (msgsnd(msgid, (void*) & data, MAX_TEXT, 0) == -1)
        {
            cout << "msget failed!";
            exit(EXIT_FAILURE);
        }
    }
    cout << "return";
}

int main()
{
    int msgid_1, msgid_2;

    msgid_1 = msgget((key_t) 1234, 0666 | IPC_CREAT);
    msgid_2 = msgget((key_t) 1235, 0666 | IPC_CREAT);

    sending(msgid_1);

}
