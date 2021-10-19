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

void client(int msgid, int client_id)
{
    int running = 1;
    struct message data;
    char buffer[BUFSIZ];
    long int message_to_recieve = 0;
    
    while(running)
    {
        if (msgrcv(msgid, (void*) & data, BUFSIZ, message_to_recieve,0) == -1)
        {
            cout << "msgrcv failed!";
            exit(EXIT_FAILURE);
        }

        cout << client_id << " Message Recieved: " << data.payload << endl;

        if (strncmp(data.payload, "end", 3) == 0)
        {
            exit(EXIT_FAILURE);
        }
    }

}

int main()
{
    int msgid_1;
    msgid_1 = msgget((key_t) 1234, 0666 | IPC_CREAT);

    thread client_2(client, msgid_1, 2);
    client(msgid_1, 1);
    client_2.join();
}
