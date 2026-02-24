#ifndef STRINGPROCESSOR_H
#define STRINGPROCESSOR_H

#include <string>

class StringProcessor {
private:
    std::string value;

public:
    StringProcessor(std::string str);

    int GetLength() const;
    std::string GetString() const;
    void SortAscending();
};

#endif
