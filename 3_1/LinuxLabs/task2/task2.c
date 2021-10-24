#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <ctype.h>

int main()
{
    FILE *firstfile;

    

    if ((fptr = fopen("./1.txt","wb")) == NULL){
       printf("Error! opening file");

       exit(EXIT_FAILURE);

   }
}