#include <sys/types.h>
#include <sys/socket.h>
#include <stdio.h>
#include <sys/un.h>
#include <stdlib.h>
#include <unistd.h>
#include <iostream>

using namespace std;

int main()
{
    int sockfd;
    int len, result;
    int num = 10;

    struct sockaddr_un address;

    sockfd = socket(AF_UNIX, SOCK_STREAM, 0);

    address.sun_family = AF_UNIX;

    strcpy(address.sun_path, "server_socket");

    len = sizeof(address);

    result = connect(sockfd, (struct sockaddr *) & address, len);

    if(result == 1)
    {
        printf("Error in connection\n");
        exit(-1);
    }

    for(int i = 0; i < 4; i++)
    {
        write(sockfd, &num, sizeof(int));
        sleep(1);

        read(sockfd, &num, sizeof(int));

        cout << "Message from server: " << num << endl;
    }

    cout << "Connection is over: " << num << endl;
    close(sockfd);
    exit(0);

}
