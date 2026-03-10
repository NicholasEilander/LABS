#include <iostream>
#include "StringProcessor.h"

int main()
{
    std::string input;

    std::cout << "Введіть: ";
    std::getline(std::cin, input);

    StringProcessor obj(input);

    std::cout << "Оригінал: " << obj.GetString() << std::endl;
    std::cout << "Довжина: " << obj.GetLength() << std::endl;

    obj.SortDescending();

    std::cout << "Результат: " << obj.GetString() << std::endl;

    return 0;
}