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
    cout << "Source code of the first section" << endl;
}


void Section2()
{
    cout << "Source code of the second section" << endl;
}

void Section3()
{
    cout << "Source code of the third section" << endl;
}






