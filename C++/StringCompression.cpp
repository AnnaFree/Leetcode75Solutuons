#include "StringCompression.h"
#include <vector>
#include <string>
class Solution {
public:
    int compress(std::vector<char>& chars) {
        int write = 0, read = 0;

        while (read < chars.size()) {
            char currentChar = chars[read];
            int count = 0;

            // Count the length of the current identical characters
            while (read < chars.size() && chars[read] == currentChar) {
                read++;
                count++;
            }
            chars[write++] = currentChar;

          //count is greater than 1, write the count
            if (count > 1) {
                std::string countStr = std::to_string(count);
                for (char c : countStr) {
                    chars[write++] = c;
                }
            }
        }
        return write;
    }
};