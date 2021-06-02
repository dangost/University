#include <iostream>
#include "logic.h"
#include <unistd.h>
#include <string>
#include <cstring>
using namespace std;

#define BUF_SIZE 4096
char buffer[BUF_SIZE+1];

int main(){

write (1, "Enter number of multiplications: ", strlen("Enter number of multiplications: "));
read (0, buffer, BUF_SIZE);
int N = atoi (buffer);
string result=multiplications(N);
const char*c=result.c_str();
write(1,c,strlen(c));
}
