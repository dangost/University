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
    int server_sockfd, clientsock_fd_1, clientsock_fd_2;

    int server_len, client_len_1, client_len_2;
    
    struct sockaddr_un server_address, client_address_1, client_address_2;
    unlink("server_socket");
    server_sockfd = socket(AF_UNIX, SOCK_STREAM, 0);

    server_address.sun_family = AF_UNIX;
    strcpy(server_address.sun_path, "server_socket");

    server_len = sizeof(server_address);
    bind(server_sockfd, (struct sockaddr*) & server_address, server_len);

    listen(server_sockfd, 5);

    int num;
    
    client_len_1 = sizeof(client_address_1);
    clientsock_fd_1 = accept(server_sockfd, (struct sockaddr*) 
                                            &client_address_1, (socklen_t*)&client_len_1);

    client_len_2 = sizeof(client_address_2);
    clientsock_fd_2 = accept(server_sockfd, (struct sockaddr*) 
                                            &client_address_2, (socklen_t*)&client_len_2);

    while (1)
    {
        cout << "Server is waiting" << endl;
        read(clientsock_fd_1, &num, sizeof(int));
        cout << "Got from client 1: " << num << endl;
        num++;
        write(clientsock_fd_1, &num, sizeof(int));
        sleep(1);

        cout << "Server is waiting" << endl;
        read(clientsock_fd_2, &num, sizeof(int));
        cout << "Got from client 2: " << num << endl;
        num++;
        write(clientsock_fd_2, &num, sizeof(int));
        sleep(1);
    }

    close(clientsock_fd_1);
    close(clientsock_fd_2);


    
}