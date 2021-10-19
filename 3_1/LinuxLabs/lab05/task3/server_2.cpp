#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <errno.h>
#include <unistd.h>
#include <sys/msg.h>
#include <iostream>

#define MAX_TEXT 512

using namespace std;

struct message
{
    long int message_type;
    char payload[BUFSIZ];
};

void sending(int msgid)
{
    cout << "enter" << endl;

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

void recieving(int msgid)
{
    int running = 1;
    struct message data;
    long int message_to_recieve = 0;
    if (msgrcv(msgid, (void*) & data, BUFSIZ, message_to_recieve,0) == -1)
    {
        cout << "msgrcv failed!";
        exit(EXIT_FAILURE);
    }

    cout << "Message Recieved: " << data.payload << endl;

    if (strncmp(data.payload, "end", 3) == 0)
    {
        exit(EXIT_FAILURE);
    }
}

int main()
{
    int running = 1;
    int msgid_1, msgid_2;
    struct message data;
    char buffer[BUFSIZ];

    msgid_1 = msgget((key_t) 1234, 0666 | IPC_CREAT);
    msgid_2 = msgget((key_t) 1235, 0666 | IPC_CREAT);

    if (msgid_1 == -1 or msgid_2 == -1)
    {
        cout << "msget failed!";
        exit(EXIT_FAILURE);
    }

    while(running)
    {
        sending(msgid_2);
        recieving(msgid_1);
    }
}
