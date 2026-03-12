#include <iostream>
#include "Triangle.h"

int main()
{
    Triangle T1;
    Triangle T2(0, 0, 4, 0, 0, 3);
    Triangle T3(T2);

    T3 = T3 * 2;
    T1 = T3 + T2;

    std::cout << "T2: " << T2.GetInfo() << std::endl;
    std::cout << "T2 Area: " << T2.GetArea() << std::endl;
    std::cout << "T2 Perimeter: " << T2.GetPerimeter() << std::endl << std::endl;

    std::cout << "T3 after * 2: " << T3.GetInfo() << std::endl;
    std::cout << "T3 Area: " << T3.GetArea() << std::endl;
    std::cout << "T3 Perimeter: " << T3.GetPerimeter() << std::endl << std::endl;

    std::cout << "T1 = T3 + T2: " << T1.GetInfo() << std::endl;
    std::cout << "T1 Area: " << T1.GetArea() << std::endl;
    std::cout << "T1 Perimeter: " << T1.GetPerimeter() << std::endl;

    return 0;
}