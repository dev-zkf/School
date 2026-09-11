//Programming Project - Lastname Firstname

#include <iostream>
#include <Windows.h>
#include <string>
#include <format>

using namespace std;

int main()
{
    //Special characters (ä, ö, ü, etc.)
    SetConsoleOutputCP(1252);
    SetConsoleCP(1252);

    cout << "Homework 0.1v:" << endl;

    string name, studentId;
    int age;
    float height, weight;
    cout << "Hello, im going to ask you some questions please awnser them." << endl;
    cout << "Name?: " << endl; getline(cin, name);
    cout << "Age?: " << endl; while (!(cin >> age)) {cout << "Try again!";cin.clear(); cin.ignore(1000, '\n');}
    cout << "StudentId?: " << endl; cin >> studentId;
    cout << "height: " << endl; cin >> height;
    cout << "weight: " << endl; cin >> weight;

    string result = format("So is this information correct? {}. Age: {}. Student ID: {}. Height: {}. Weight: {}.", name, age, studentId, height, weight);
    cout << result << endl;
    
    system("pause");
}





