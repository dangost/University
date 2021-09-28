#include <sys/types.h>
#include <sys/socket.h>
#include <stdio.h>
#include <sys/un.h>
#include <unistd.h>
#include <stdlib.h>
#include <iostream>
#include <thread>

using namespace std;


void polling(int id, int server_sockfd, sockaddr_un client_address, int client_len, int clientsock_fd)
{
    cout << id << " started";
    int num;
    
    client_len = sizeof(client_address);
    clientsock_fd = accept(server_sockfd, (struct sockaddr*) 
                                            &client_address, (socklen_t*)&client_len);
    while (1)
    {
        cout << "Server is waiting" << endl;
        read(clientsock_fd, &num, sizeof(int));
        cout << "Got from client "<< id << ": " << num << endl;
        num++;
        write(clientsock_fd, &num, sizeof(int));
        sleep(1);
    }

    
}

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

    thread thread_client_1(polling, 1, server_sockfd, client_address, client_len, clientsock_fd);
    thread thread_client_2(polling, 2, server_sockfd, client_address, client_len, clientsock_fd);    

    thread_client_1.join();
    thread_client_2.join();
}
