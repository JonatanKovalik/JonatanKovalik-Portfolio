/*
    Created by Jonatan Kovalilk!!
    29/06/2025
*/
#include <iostream>
#include <cstdlib>
#include <ctime>
void game();
int main()
{
    srand(static_cast<unsigned int>(time(0)));

    std::cout << "Hello! I'm Alex.\n";
    std::cout << "I've got a fun guessing game for you. Want to play? (Y/N)\n";

    char user_choice;
    std::cin >> user_choice;
    std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
    if (user_choice == 'Y' || user_choice == 'y') {
        std::cout << "Great! Let's start the game.\n";
        game();
    }
    else {
        std::cout << "No problem! Maybe next time. Goodbye.\n";
    }
    std::cout << "\nPress Enter to exit.\n";
    std::cin.get();
    return 0;
}

void game()
{
    const int secretNumber = rand() % 100 + 1;
    int guess = 0;
    int attempts = 0;
    std::cout << "Okay, I've got a secret number in mind. What's your first guess?\n";
    while (guess != secretNumber){
        std::cout << "Enter your guess: ";
        std::cin >> guess;
        if (std::cin.fail())
        {
            std::cout << "Invalid input. Please enter a number.\n";
            std::cin.clear();
            std::cin.ignore(std::numeric_limits<std::streamsize>::max(), '\n');
            continue;
        }

        attempts++;

        if (guess > secretNumber) {
            std::cout << "Too high! My secret number is lower than that.\n";
        }
        else if (guess < secretNumber) {
            std::cout << "Too low! My secret number is bigger than that.\n";
        }
        else {
            std::cout << "\nCongratulations! You picked the right number I was thinking of!\n";
            std::cout << "It took you " << attempts << " attempts.\n";
            break;
        }
    }
}