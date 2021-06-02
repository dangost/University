#include "fileUtils.h"
#include <stdio.h>
#include <fcntl.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <unistd.h>

#define BUF_SIZE 4096
char buffer[BUF_SIZE + 1];

int createFile(char* filename)
{
int fd;
mode_t fmode = S_IRUSR | S_IWUSR | S_IRGRP;
fd = creat(filename, fmode);
if (fd == -1)
{
fprintf(stderr, "Cannot create file\n");
return 1;
}

close(fd);
return 0;
}

void fileAppend(char* filename, int* massive, int size)
{
int fd;
fd = open(filename, O_WRONLY | O_TRUNC);

for(int i = 0; i < size; i++)
{
write(fd, &massive[i], sizeof(int));
}


//int f = write(fd, massive, SIZE);
close(fd);
}

void fileRead(char* filename, int* massive, int size)
{
int fd;
fd = open(filename, O_RDONLY);

for(int i = 0; i < size; i++)
{
read(fd, &massive[i], sizeof(int));
}

close(fd);
} 
