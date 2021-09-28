#include <sys/types.h>
#include <sys/socket.h>
#include <stdio.h>
#include <sys/un.h>
#include <unistd.h>
#include <stdlib.h>
#include <iostream>

using namespace std;

int main()
{
    int server_sockfd, clientsock_fd;

    int server_len, client_len;
    
    struct sockaddr_un server_address, client_address;
    unlink("server_socket");
    server_sockfd = socket(AF_UNIX, SOCK_STREAM, 0);

    server_address.sun_family = AF_UNIX;
    strcpy(server_address.sun_path, "server_socket");

    server_len = sizeof(server_address);
    bind(server_sockfd, (struct sockaddr*) & server_address, server_len);

    listen(server_sockfd, 5);

    int num;
    
    client_len = sizeof(client_address);
    clientsock_fd = accept(server_sockfd, (struct sockaddr*) 
                                            &client_address, (socklen_t*)&client_len);

    while (1)
    {
        cout << "Server is waiting" << endl;
        read(clientsock_fd, &num, sizeof(int));
        cout << "Got from client: " << num << endl;
        num *= num;
        write(clientsock_fd, &num, sizeof(int));
        sleep(1);
    }

    close(clientsock_fd);


    
}