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
    int server_id;
    long int message_type;
    char payload[BUFSIZ];
};

void sending(int msgid, int server_id)
{
    cout << "enter" << endl;

    struct message data;
    data.server_id = server_id;
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

int main()
{
    int running = 1;
    int msgid_1, msgid_2;
    struct message data;
    char buffer[BUFSIZ];

    msgid_1 = msgget((key_t) 1234, 0666 | IPC_CREAT);

    if (msgid_1 == -1 or msgid_2 == -1)
    {
        cout << "msget failed!";
        exit(EXIT_FAILURE);
    }

    while(running)
    {
        sending(msgid_1, 2);
    }
}
