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
        cout << "enter some text" << endl;
        fgets(buffer, BUFSIZ, stdin);

        data.message_type = 1;

        strcpy(data.payload, buffer);

        if (msgsnd(msgid_1, (void*) & data, MAX_TEXT, 0) == -1)
        {
            cout << "msget failed!";
            exit(EXIT_FAILURE);
        }

        if (msgsnd(msgid_2, (void*) & data, MAX_TEXT, 0) == -1)
        {
            cout << "msget failed!";
            exit(EXIT_FAILURE);
        }
        
        if (strncmp(buffer, "end", 3))
        {
            running = 0;
        }

        cout << "servermsg ended!" << endl;
        exit(EXIT_SUCCESS);
    }
}
