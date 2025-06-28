#include <iostream> // Every code this row need be draw
#include <cstdlib> // Random 
#include <ctime>   // Time()
#include <string> // Type Str
#include <Windows.h> // sleep for windows
#include <math.h>
#include <vector>

//this my first code in c++
//subject code: ID creator and Math
//Creator Jonatan Kovalik
//Data Start: 28/10/24
//Data End: 30/10/2024

//invite
void Math(); 

std::string MainCode();

void functioncreat5newnumberranodm();

void mathidk2();

std::string areyousure();

void Math() {
    std::string Name = MainCode();
    std::string Whatyouwanttodo;
    std::cout << "Welcome to Math Program Enjoy!" << '\n';
    Sleep(1000);
    std::cout << "Hello Sir, your name is: " + Name + ". Welcome to Math!" << '\n';
    Sleep(1500);
    std::cout << "What do you want to do? (+ or - or * or / or ** or //)" << '\n';
    std::cin >> Whatyouwanttodo;

    if (Whatyouwanttodo == "+") {
        float a = 0;
        float b = 0;
        std::string anothernumber;
        std::cout << "Please give me your first number: " << '\n';
        std::cin >> a;
        Sleep(1500);
        std::cout << "Thanks, now I need another number to add: " << '\n';
        std::cin >> b;
        Sleep(1500);
        std::cout << "Do you have another number you want to add? (Yes or No)" << '\n';
        std::cin >> anothernumber;

        if (anothernumber == "Yes" || anothernumber == "yes") {
            int parts = 0;
            float total = a + b; 
            std::vector<float> numbers;

            std::cout << "Ok, how many parts do you have? (Max parts 5, Min 2!)" << '\n';
            std::cin >> parts;

            if (parts >= 2 && parts <= 5) {
                for (int i = 1; i <= parts - 2; ++i) {
                    float num;
                    std::cout << "What is part " << i + 2 << " number?" << '\n';
                    std::cin >> num;
                    total += num; 
                    numbers.push_back(num); 
                    Sleep(500);
                }
                std::cout << "Your total is: " << total << '\n';
            }
            else {
                std::cout << "Invalid number of parts. Please enter between 2 and 5." << '\n';
            }
        }
        else if (anothernumber == "No" || anothernumber == "no") {
            std::string Conorquit;
            std::cout << "Your finished number: " + std::to_string(a) + " + " + std::to_string(b) + " = " + std::to_string(a + b) << '\n';
            Sleep(1000);
            std::cout << "Do you want to Quit or continue?" << '\n';
            std::cin >> Conorquit;
            if (Conorquit == "Quit") {
                mathidk2();
            }
            else if (Conorquit == "continue") {
                Math();
            }
        }
    }
}

std::string MainCode() {
    HANDLE colorconsol = GetStdHandle(STD_OUTPUT_HANDLE);
    std::string myname;
    std::string country;
    std::string databorn;

    SetConsoleTextAttribute(colorconsol, 7);
    std::cout << "What is your full name?" << '\n';
    std::cin >> myname;
    std::cout << "Ok, Next Question!" << '\n';
    SetConsoleTextAttribute(colorconsol, 2);
    for (int i = 0; i < 3; ++i) {
        std::cout << "Loading" << std::string(i + 1, '.') << '\n';
        Sleep(500);
    }

    SetConsoleTextAttribute(colorconsol, 7);
    std::cout << "What country were you born in?" << "\n";
    std::cin >> country;
    std::cout << "Ok, Next Question!" << '\n';
    SetConsoleTextAttribute(colorconsol, 2);
    for (int i = 0; i < 3; ++i) {
        std::cout << "Loading" << std::string(i + 1, '.') << '\n';
        Sleep(500);
    }

    SetConsoleTextAttribute(colorconsol, 7);
    std::cout << "What is your date of birth?" << '\n';
    std::cin >> databorn;
    std::cout << "Ok, Next Question!" << '\n';
    SetConsoleTextAttribute(colorconsol, 2);
    for (int i = 0; i < 3; ++i) {
        std::cout << "Loading" << std::string(i + 1, '.') << '\n';
        Sleep(500);
    }

    system("CLS"); // Clear console!!
    SetConsoleTextAttribute(colorconsol, 7);
    std::cout << "Thank you for all the info. Now we will generate your ID." << '\n';
    functioncreat5newnumberranodm();
    return myname;
}

std::string areyousure() {
    std::string YesorNo;
    HANDLE colorconsol = GetStdHandle(STD_OUTPUT_HANDLE);
    SetConsoleTextAttribute(colorconsol, 5);
    std::cout << "Do you want a Math Test? (Yes or No)" << '\n';
    std::cin >> YesorNo;
    return YesorNo;
}

void mathidk2() {
    std::string YesorNo = areyousure();
    if (YesorNo == "Yes" || YesorNo == "yes") {
        Math(); 
    }
    else if (YesorNo == "No" || YesorNo == "no") {
        std::cout << "Ok, Goodbye!!";
    }
    else {
        std::cout << "Error, your answer is unclear!" << '\n';
        mathidk2(); 
    }
}

void functioncreat5newnumberranodm() {
    srand(time(NULL));
    int id[5];
    for (int i = 0; i < 5; i++) {
        id[i] = rand() % 10; 
    }
    std::cout << "Your ID: " + std::to_string(id[0]) + std::to_string(id[1]) + std::to_string(id[2]) + std::to_string(id[3]) + std::to_string(id[4]) << '\n';
}

int main() {
    std::string start = areyousure();
    if (start == "yes" || start == "Yes") {
        Math();
    }
    else if (start == "No" || start == "no") {
        std::cout << "Ok Goodbye!!" << '\n';
    }
    else {
        std::cout << "Error, your answer is unclear!" << '\n';
        main(); 
    }
    return 0;
}

/*void main() {
	int number = 0;
	int numberrow = 1;
	while (number != 30000000) {
		std::string stringrow = std::to_string(numberrow);
		std::cout << "I love you" + stringrow << '\n';
		number += 1;
		numberrow += 1;
		Sleep(0);
	}
	std::cout << numberrow << '\n';
}*/