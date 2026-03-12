#include "Triangle.h"
#include <cmath>
#include <sstream>

Triangle::Triangle()
{
    x1 = 0; y1 = 0;
    x2 = 1; y2 = 0;
    x3 = 0; y3 = 1;
}

Triangle::Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
{
    this->x1 = x1;
    this->y1 = y1;
    this->x2 = x2;
    this->y2 = y2;
    this->x3 = x3;
    this->y3 = y3;
}

Triangle::Triangle(const Triangle& other)
{
    x1 = other.x1;
    y1 = other.y1;
    x2 = other.x2;
    y2 = other.y2;
    x3 = other.x3;
    y3 = other.y3;
}

double Triangle::Distance(double ax, double ay, double bx, double by) const
{
    return std::sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
}

double Triangle::GetPerimeter() const
{
    double ab = Distance(x1, y1, x2, y2);
    double bc = Distance(x2, y2, x3, y3);
    double ca = Distance(x3, y3, x1, y1);

    return ab + bc + ca;
}

double Triangle::GetArea() const
{
    return std::abs(
        x1 * (y2 - y3) +
        x2 * (y3 - y1) +
        x3 * (y1 - y2)
    ) / 2.0;
}

std::string Triangle::GetInfo() const
{
    std::ostringstream out;
    out << "A(" << x1 << ", " << y1 << "), "
        << "B(" << x2 << ", " << y2 << "), "
        << "C(" << x3 << ", " << y3 << ")";
    return out.str();
}

Triangle Triangle::operator+(const Triangle& other) const
{
    return Triangle(
        x1 + other.x1, y1 + other.y1,
        x2 + other.x2, y2 + other.y2,
        x3 + other.x3, y3 + other.y3
    );
}

Triangle Triangle::operator*(double factor) const
{
    return Triangle(
        x1 * factor, y1 * factor,
        x2 * factor, y2 * factor,
        x3 * factor, y3 * factor
    );
}