#include "StringProcessor.h"
#include <algorithm>
#include <functional>

StringProcessor::StringProcessor()   
{
    value = "";
}

StringProcessor::StringProcessor(std::string str)
{
    value = str;
}

StringProcessor::~StringProcessor()  
{
    // Деструктор
}

int StringProcessor::GetLength() const
{
    return value.length();
}

std::string StringProcessor::GetString() const
{
    return value;
}

void StringProcessor::SortDescending()   
{
    std::sort(value.begin(), value.end(), std::greater<char>());
}