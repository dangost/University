#include <string>
#include "logic.h"

using namespace std;

string multiplications(int N);
bool CheckExist(int first_num, int second_num, int* array, int N);

string multiplications(int N) {
srand(time(0));

int* old = new int[N];
for (int i = 0; i < N; i++)
{
old[i] = 0;
}

string result = "";
int first_num, second_num;
for (int i = 0; i < N; i++)
{
bool repeat = true;
while (repeat)
{
first_num = rand() % 8 + 2;
second_num = rand() % 8 + 2;
repeat = CheckExist(first_num, second_num, old, N);
}
result += to_string(first_num) + " * " + to_string(second_num) + "\n";
}
return result;
}

bool CheckExist(int first_num, int second_num, int* array, int N)
{
for (int i = 0; i < N; i++)
{
if (array[i] == 0) {
array[i] = first_num * 10 + second_num;
return false;
}

int num1 = array[i] / 10;
int num2 = array[i] % 10;

if (first_num == num1)
{
if (second_num == num2)
{
return true;
}
}
else if (first_num == num2)
{
if (second_num == num1)
{
return true;
}
}
}
return false;
}
