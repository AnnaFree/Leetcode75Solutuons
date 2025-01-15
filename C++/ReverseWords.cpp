#include "ReverseWords.h"
#include <iostream>
#include <string>


	std::string reverseWords(std::string s) {
        std::string result;
        int end = s.length() - 1, start;

        while (end >= 0) {
            while (end >= 0 && s[end] == ' ') {
                end--;
            }

            if (end < 0) break;
            start = end;
            while (start >= 0 && s[start] != ' ') {
                start--;
            }

            if (!result.empty()) {
                result += " "; // Add space
            }
            result += s.substr(start + 1, end - start);

            // Move the end pointer to process the next word
            end = start - 1;
        }

        return result;
	}
