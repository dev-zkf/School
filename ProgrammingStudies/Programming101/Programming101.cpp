//Programming Project - Ortela Miro

#include <iostream>
#include <Windows.h>
#include <string>
#include <format>
#include <cctype>
#include <algorithm>

using namespace std;

void displayMenu(int i), page1(), page2(), sentenceInfo();

int main()
{
    //Special characters (ä, ö, ü, etc.)
    SetConsoleOutputCP(1252);
    SetConsoleCP(1252);

    int opt;

    while (true) {
        displayMenu(0);
        while (!(cin >> opt)) { cout << "Maybe try again: "; cin.clear(); cin.ignore(1000, '\n'); }

        if (opt == 0) {
            cout << "Exiting program...";
            break;
        }

        switch (opt) {
            case 1: { page1(); break; }
            case 2: { page2(); break; }
            case 3: { sentenceInfo(); break; }
            default: cout << "Invalid option! Please try again.\n"; break;
        }
    }
}

void page1()
{
    string name, studentId;
    int age;
    float height, weight;
    cout << "Hello, im going to ask you some questions please awnser them." << endl;
    cout << "Name?: "; cin >> name;
    cout << "\nAge?: "; while (!(cin >> age)) { cout << "Try again!"; cin.clear(); cin.ignore(1000, '\n'); }
    cout << "\nStudentId?: "; cin >> studentId;
    cout << "\nheight: "; cin >> height;
    cout << "\nweight: "; cin >> weight;

    string result = format("So is this information correct? {}. Age: {}. Student ID: {}. Height: {}. Weight: {}.", name, age, studentId, height, weight);
    cout << result << endl;

    system("pause");
}

void page2()
{
    int opt;
    char ABC = 'B';
    tolower(ABC);

    while (true) {
        displayMenu(1);
        while (!(cin >> opt)) { cout << "Maybe try again: "; cin.clear(); cin.ignore(1000, '\n'); }

        if (opt == 0) {
            cout << "Exiting program...";
            break;
        }

        switch (opt) {
        case 1: {
            cout << "Converting points to grade...\n";
            cout << "Enter point amount: ";
            int points;
            while (true) {
                cin >> points;
                if (points < 0 || points > 100)
                    cout << "Invalid point amount. Grading range is 0-100. Enter a valid amount: ";
                else
                    break;
            }

            // check if points is less than 50 if so then automatic fail (0), else check again points but if their less than 89 else would be passing
            // if it is under 89 points then divide by 10 (60 -> 6 - 4 = 2) which is in the 60-69 grade range 
            int grade = points < 50 ? 0 : (points > 89 ? 5 : points / 10 - 4);

            cout << format("Your grade is: [{}]!\n", grade);
            if (points == 100)
                cout << "Congratulations, you got full points!" << endl;
            break;
        }
        case 2: {
            cout << "Converting to miles..." << endl;
            cout << "Enter distance (km) to convert to miles: ";

            float kilometer;
            cin >> kilometer;
            cout << format("Distance in miles: {}", kilometer / 1.609);
            break;
        }
        case 3: {
            cout << "Converting to nautical miles...";
            cout << "Enter distance (km) to convert to nautical miles: ";

            float kilometer;
            cin >> kilometer;
            cout << format("Distance in nautical miles: {}", kilometer / 1.852);
            break;
        }
        default:
            cout << "Invalid option! Please try again.\n";
            break;
        }
    }
}

void sentenceInfo()
{
    string input;

    cin.ignore();
    do {
        cout << "Write a sentence: ";
        getline(cin, input);
    }
    while (input.size() == 0);
    
    int sentenceCount = 0;
    int wordCount = 0;

    bool inSentence = false;
    bool inWord = false;

    for (char ch : input) {
        if (ch == '.' || ch == '!' || ch == '?') {
            inSentence = false;
            inWord = false;
        }
        else if (ch == ' ') {
            inWord = false;
        }
        else {
            // Start of a new word.
            if (!inWord && isalpha(ch)) {
                inWord = true;
                wordCount++;
            }

            // Start of a new sentence.
            if (!inSentence && ch != ',') {
                inSentence = true;
                sentenceCount++;
            }
        }
    }

    string output = format(R"(
Word Count: {}
Sentence Count: {}
Text Complexity: {})", wordCount, sentenceCount, sentenceCount > 2 ? "COMPLEX" : "SIMPLE");

    cout << output;
}

void displayMenu(int i)
{
    switch (i)
    {
        case 0:
        {
            cout << "\n---- Homework Browser ----\n"
                << "1 - Questionaire\n"
                << "2 - Kilometre converter\n"
                << "3 - Sentence Info\n"
                << "0 - Quit\n"
                << "Enter choice: ";
            break;
        }
        case 1:
        {
            cout << "\n---- C++ Converter ----\n"
                << "1 - Convert points to grade\n"
                << "2 - Convert to miles\n"
                << "3 - Convert to nautical miles\n"
                << "0 - Back\n"
                << "Enter choice: ";
            break;
        }
    }
}