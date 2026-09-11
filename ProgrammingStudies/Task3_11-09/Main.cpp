//Programming Project - Miro Ortela

#include <iostream>
#include <Windows.h>

using namespace std;

void Section1();
void Section2();
void Section3();
void TuntiTeht5();
int main()
{
    //Special characters (ä, ö, ü, etc.)
    SetConsoleOutputCP(1252);
    SetConsoleCP(1252);

    cout << "The program starts:" << endl;

    Section1();
    Section2();
    Section3();
    TuntiTeht5();

    system("pause");
}

void Section1()
{
    string w1 = "My";
    string w2 = "own";
    string w3 = "hello";
    string w4 = "world!";

    cout << w1 << " " << w2 << " " << w3 << " " << w4 << endl;
}

void Section2()
{
    const char *paragraph = R""""(
Quotation mark denotes on the beginning and end of a constamt text within code, so it can't be used as such in the text conten. It has to be escaped using backslash in front of it:
\"October's Gold\"

Haiku "October's Gold" By Paul Holmes

Like crunchy cornflakes
Gold leaves rustle underfoot
Beauty in decay.)"""";

    cout << paragraph << "\n\n";
}

void Section3()
{
}

void TuntiTeht5() {
    cout << "If this text"; cout << " appears on your display, ";
    cout << endl;
    cout << "you can pat yourself on" << " the back!\n" << endl;
}