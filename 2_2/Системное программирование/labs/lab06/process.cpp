#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <dirent.h>
#include <fnmatch.h>
#include <sys/types.h>
#include <sys/stat.h>
#include <unistd.h>

void processdir(const struct dirent *dir)
{
     printf("UID: %s \n", dir->d_name);
}

int filter(const struct dirent *dir)
{
     return !fnmatch("[1-9]*", dir->d_name, 0);
}

int main() 
{

     struct dirent **namelist;
     int n;

     n = scandir("/proc", &namelist, filter, 0);
     if (n < 0)
     {
	  perror("Not enough memory.");
     }
     else 
     {

	  while(n--) 
       {
          processdir(namelist[n]);
          free(namelist[n]);
	  }

	  free(namelist);
     }

     return 0;
}