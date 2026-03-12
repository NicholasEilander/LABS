#ifndef TRIANGLE_H
#define TRIANGLE_H

#include <string>

class Triangle
{
private:
    double x1, y1, x2, y2, x3, y3;

    double Distance(double ax, double ay, double bx, double by) const;

public:
    Triangle();
    Triangle(double x1, double y1, double x2, double y2, double x3, double y3);
    Triangle(const Triangle& other);

    double GetPerimeter() const;
    double GetArea() const;
    std::string GetInfo() const;

    Triangle operator+(const Triangle& other) const;
    Triangle operator*(double factor) const;
};

#endif