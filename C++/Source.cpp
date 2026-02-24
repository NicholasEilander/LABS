#include <iostream>
#include "StringProcessor.h"

int main() {
    std::string input;

    std::cout << "Enter string: ";
    std::getline(std::cin, input);

    StringProcessor obj(input);

    std::cout << "Original string: " << obj.GetString() << std::endl;
    std::cout << "Length: " << obj.GetLength() << std::endl;

    obj.SortAscending();

    std::cout << "Sorted string: " << obj.GetString() << std::endl;

    return 0;
}