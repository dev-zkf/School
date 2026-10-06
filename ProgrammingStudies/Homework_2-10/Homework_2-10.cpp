//Programming Project - Ortela Miro

#include <iostream>
#include <Windows.h>
#include <string>
#include <format>

using namespace std;

void displayMenu();

int main()
{
    //Special characters (ä, ö, ü, etc.)
    SetConsoleOutputCP(1252);
    SetConsoleCP(1252);

    char opt;

    while (true) {
        displayMenu();
        cin >> opt;

        if (opt == '0') {
            cout << "Exiting program...";
            break;
        }

        switch (opt) {
        case '1': {
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
        case '2': {
            cout << "Converting to miles..." << endl;
            cout << "Enter distance (km) to convert to miles: ";

            float kilometer;
            cin >> kilometer;
            cout << format("Distance in miles: {}", kilometer / 1.609);
            break;
        }
        case '3': {
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

void displayMenu() {
    cout << "\n---- C++ Converter ----\n"
        << "1 - Convert points to grade\n"
        << "2 - Convert to miles\n"
        << "3 - Convert to nautical miles\n"
        << "0 - Quit\n"
        << "Enter choice: ";
}





