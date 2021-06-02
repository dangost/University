#include <iostream>
#include "task1.h"

using namespace std;


int main()
{
    cout << "Choose lab\n1)Task01\n2)Exit\n";

    int ans; cin >> ans;

    if(ans == 1)
    {
        task1();
    }

}