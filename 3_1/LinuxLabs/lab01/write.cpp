#include <unistd.h>
#include <stdlib.h>
#include <string.h>
#include <stdio.h>
#define BUFSIZZ 256

int main()
{
    FILE* write_fp;
    char buffer[BUFSIZZ+1];
    sprintf(buffer, "Welcome to Linux community!\n");

    write_fp = popen("cat", "w");

    fwrite(buffer, sizeof(char), strlen(buffer), write_fp);

    pclose(write_fp);

    exit(0);

}