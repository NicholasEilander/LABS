#ifndef STRINGPROCESSOR_H
#define STRINGPROCESSOR_H

#include <string>

class StringProcessor
{
private:
    std::string value;

public:
    StringProcessor();                    
    StringProcessor(std::string str);     
    ~StringProcessor();                   

    int GetLength() const;
    std::string GetString() const;
    void SortDescending();                
};

#endif