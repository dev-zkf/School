//Programming Project - Lastname Firstname

#include <iostream>
#include <Windows.h>

using namespace std;

void Section1();
void Section2();
void Section3();



int main()
{
    //Special characters (ä, ö, ü, etc.)
    SetConsoleOutputCP(1252);
    SetConsoleCP(1252);

    cout << "The program starts:" << endl;

    Section1();
    Section2();
    Section3();

    system("pause");
}

void Section1()
{
    // Variables
    int intNum = 5;
    float floatNum = 5.3;
    double doubleNum = 10.1;
    int sum;
    float fSum = intNum + floatNum + doubleNum;
    sum = fSum;
    cout << "INT Sum is: " << sum << "\nFLOAT Sum is: " << fSum << endl;
}


void Section2()
{
    int sum0 = 150, sum1 = 300;

    cout << "Before swapping sum0 = " << sum0 << " , sum1 = " << sum1 << endl;

    int temp;

    temp = sum0;
    sum0 = sum1;
    sum1 = temp;
    cout << "After swapping sum0 = " << sum0 << " , sum1 = " << sum1 << endl;
}

void Section3()
{
    cout << "" << endl;
}