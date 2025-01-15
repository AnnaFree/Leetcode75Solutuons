#include "isSequence.h"
#include <string>
bool isSubsequence(std::string s, std::string t) {
    int counter = 0;
    int i = 0;
    while (i < t.size()) {
        if (s[counter] == t[i]) {
            counter++;
        }
        i++;
    }
    if (counter == s.size()) {
        return true;
    }
    else {
        return false;
    }
}