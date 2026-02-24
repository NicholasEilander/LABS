#include "StringProcessor.h"
#include <algorithm>

StringProcessor::StringProcessor(std::string str) {
    value = str;
}

int StringProcessor::GetLength() const {
    return value.length();
}

std::string StringProcessor::GetString() const {
    return value;
}

void StringProcessor::SortAscending() {
    std::sort(value.begin(), value.end());
}