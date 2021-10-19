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

void recieving(int msgid)
{
    int running = 1;
    struct message data;
    long int message_to_recieve = 0;

    while(running) 
    {
        if (msgrcv(msgid, (void*) & data, BUFSIZ, message_to_recieve,0) == -1)
        {
            cout << "msgrcv failed!";
            exit(EXIT_FAILURE);
        }

        cout << "Message Recieved: " << data.payload << endl;

        if (strncmp(data.payload, "end", 3) == 0)
        {
            running = 0;
        }
    }
}

int main()
{
    int msgid_1, msgid_2;

    msgid_1 = msgget((key_t) 1234, 0666 | IPC_CREAT);
    msgid_2 = msgget((key_t) 1235, 0666 | IPC_CREAT);

    recieving(msgid_1);
}
