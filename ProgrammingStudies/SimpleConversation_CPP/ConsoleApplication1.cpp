//Programming Project - Miro Ortela

#include <iostream>
#include <Windows.h>

using namespace std;

void Section1();
void Section2();
void Section3();

string name;
int age;

int main()
{
    //Special characters (ä, ö, ü, etc.)
    SetConsoleOutputCP(1252);
    SetConsoleCP(1252);

    cout << "The program starts:" << endl;

    Section1();

    //Section2();
    //Section3();

    system("pause");
}

void Section1()
{
    cout << "Source code of the first section" << endl;

    cout << "What is your name?: ";
    cout << "How old are you?: ";
    // Check if age is a number & re-ask

    while (!(cin >> age)) {
        cout << "Enter a valid age!";
        cin.clear();
        cin.ignore(1000, '\n');
    }
    
    cout << "hello, " + name << endl;
    cout << "Wait you are " << age << " years old??" << endl;
}

void Section2()
{
    cout << "Section 2 is empty" << endl;
}

void Section3()
{
    cout << "Source code of the third section" << endl;
}





